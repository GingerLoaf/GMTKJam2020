using System.Collections.Generic;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class ColliderEmitter : MonoBehaviour
{

    [SerializeField]
    private StringReference m_allowedTag = null;

    [SerializeField]
    private ColliderEventReference m_onTriggerEnter = null;

    [SerializeField]
    private ColliderEventReference m_onTriggerStay = null;

    [SerializeField]
    private ColliderEventReference m_onTriggerExit = null;

    private readonly List<Collider> m_triggeredObjects = new List<Collider>();

    private void OnDisable()
    {
        if (m_triggeredObjects.Count > 0)
        {
            for (int i = 0; i < m_triggeredObjects.Count; i++)
            {
                m_onTriggerExit?.Event?.Raise(m_triggeredObjects[i]);
            }
        }

        m_triggeredObjects.Clear();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!IsAllowed(other.transform))
        {
            return;
        }

        m_onTriggerEnter?.Event?.Raise(other);
        m_triggeredObjects.Add(other);
    }

    private void OnTriggerStay(Collider other)
    {
        if (!IsAllowed(other.transform))
        {
            return;
        }

        m_onTriggerStay?.Event?.Raise(other);
    }

    private void OnTriggerExit(Collider other)
    {
        if (!IsAllowed(other.transform))
        {
            return;
        }

        m_onTriggerExit?.Event?.Raise(other);
        m_triggeredObjects.Remove(other);
    }

    private bool IsAllowed(Transform other)
    {
        if (m_allowedTag == null)
        {
            return true;
        }

        return other.CompareTag(m_allowedTag.Value);
    }

}
