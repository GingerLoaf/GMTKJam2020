using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class DistractionManager : MonoBehaviour
{

    [SerializeField]
    private Vector3EventReference m_onDistractionPositionSet = null;

    [SerializeField]
    private GameObjectReference m_player = null;

    private readonly List<Distraction> m_orderedDistractions = new List<Distraction>();

    private CancellationTokenSource m_tokenSource = null;
    private Bud m_bud = null;

    private void OnEnable()
    {
        m_tokenSource = new CancellationTokenSource();
        MonitorDistractionsAsync(m_tokenSource.Token);
    }

    private void OnDisable()
    {
        m_tokenSource?.Cancel();
        m_tokenSource?.Dispose();
        m_tokenSource = null;
    }

    private async void MonitorDistractionsAsync(CancellationToken cancellationToken)
    {
        while (true)
        {
            try
            {
                await Task.Delay(1000, cancellationToken);

                m_bud = m_bud ?? m_player.Value.GetComponent<Bud>();
                if (m_bud != null)
                {
                    if (!m_bud.IsPathing && m_orderedDistractions.Count > 0)
                    {
                        m_onDistractionPositionSet?.Event?.Raise(m_orderedDistractions[0].PointOfInterest);
                    }
                }

                if (PruneAndSort() && m_orderedDistractions.Count > 0)
                {
                    m_onDistractionPositionSet?.Event?.Raise(m_orderedDistractions[0].PointOfInterest);
                }
            }
            catch (OperationCanceledException)
            {
                break;
            }
        }
    }

    public void AddDistraction(Distraction distraction)
    {
        if (m_orderedDistractions.Contains(distraction))
        {
            return;
        }

        m_orderedDistractions.Add(distraction);
        PruneAndSort();

        m_onDistractionPositionSet?.Event?.Raise(m_orderedDistractions[0].PointOfInterest);
    }

    public void RemoveDistraction(Distraction distraction)
    {
        if (!m_orderedDistractions.Remove(distraction))
        {
            return;
        }

        PruneAndSort();

        if (m_orderedDistractions.Count > 0)
        {
            m_onDistractionPositionSet?.Event?.Raise(m_orderedDistractions[0].PointOfInterest);
        }
    }

    private bool PruneAndSort()
    {
        if (m_orderedDistractions.Count == 0)
        {
            return false;
        }

        var didRemoveItems = false;
        for (int i = m_orderedDistractions.Count - 1; i >= 0; i--)
        {
            if (m_orderedDistractions[i] == null || !m_orderedDistractions[i].enabled || !m_orderedDistractions[i].gameObject.activeInHierarchy)
            {
                m_orderedDistractions.RemoveAt(i);
                didRemoveItems = true;
            }
        }

        m_orderedDistractions.Sort((a, b) => b.Priority.CompareTo(a.Priority));

        return didRemoveItems;
    }

}
