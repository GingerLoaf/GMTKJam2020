using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class Distraction : MonoBehaviour
{

    public int Priority => m_priority?.Value ?? 0;

    public Vector3 PointOfInterest
    {
        get
        {
            if (m_pointOfInterest == null)
            {
                return transform.position;
            }

            if (m_pointOfInterest.Value == null)
            {
                return transform.position;
            }

            return m_pointOfInterest.Value.transform.position;
        }
    }

    [SerializeField]
    private GameObjectReference m_pointOfInterest = null;

    [SerializeField]
    private IntReference m_priority = null;

    [SerializeField]
    private DistractionEventReference m_onDistractionEnter = null;

    [SerializeField]
    private DistractionEventReference m_onDistractionExit = null;

    public void OnEnter()
    {
        m_onDistractionEnter?.Event?.Raise(this);
    }

    public void OnExit()
    {
        m_onDistractionExit?.Event?.Raise(this);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(PointOfInterest, 3f);
        Gizmos.color = Color.white;
    }

}
