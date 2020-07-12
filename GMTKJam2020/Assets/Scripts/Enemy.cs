using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour, IClickable
{

    [SerializeField]
    private NavMeshAgent m_navAgent = null;

    private GameObject m_gameObject = null;

    void IClickable._HandleClick()
    {
        Destroy(gameObject);
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
