using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour, IClickable
{

    [SerializeField]
    private NavMeshAgent m_navAgent = null;

    [SerializeField]
    private IntReference m_currentHealth = null;

    [SerializeField]
    private IntReference m_maxHealth = null;

    [SerializeField]
    private Transform m_visualsParent = null;

    [SerializeField]
    private FloatReference m_wobbleAmount = null;

    [SerializeField]
    private FloatReference m_wobbleSpeed = null;

    private GameObject m_gameObject = null;

    private void OnEnable()
    {
        m_maxHealth.Value = m_currentHealth.Value = Mathf.RoundToInt(transform.localScale.magnitude);
    }

    public void ChangeHealth(int delta)
    {
        m_currentHealth.Value += delta;

        if (m_currentHealth <= 0)
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

    private void Start()
    {
        if (NavMesh.SamplePosition(transform.position, out NavMeshHit hit, 5f, NavMesh.AllAreas))
        {
            m_navAgent.Warp(hit.position);
        }
    }

    private void Update()
    {
        if (!m_navAgent.isStopped && m_gameObject != null)
        {
            m_navAgent.SetDestination(m_gameObject.transform.position);
        }

        CharacterUtility.UpdateWobble(m_visualsParent, m_navAgent.desiredVelocity, m_wobbleSpeed, m_wobbleAmount, false);
    }

}
