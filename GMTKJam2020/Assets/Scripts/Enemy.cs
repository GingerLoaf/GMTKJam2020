using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour, IClickable
{

    [SerializeField]
    private NavMeshAgent m_navAgent = null;

    [SerializeField]
    private IntReference m_health = null;

    private GameObject m_gameObject = null;

    private void OnEnable()
    {
        m_health.Value = 9;
    }

    public void ChangeHealth(int delta)
    {
        m_health.Value += delta;

        if (m_health <= 0)
        {
            Destroy(gameObject);
        }
    }

    bool IClickable._IsFriendly => false;

    void IClickable._HandleClick()
    {
        ChangeHealth(-1);
    }

    public void SetTarget(GameObject gameObject)
    {
        m_gameObject = gameObject;
        m_navAgent.isStopped = gameObject == null;
    }

    private void Update()
    {
        if (!m_navAgent.isStopped && m_gameObject != null)
        {
            m_navAgent.SetDestination(m_gameObject.transform.position);
        }
    }

}
