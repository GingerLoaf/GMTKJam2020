using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.AI;

public class Bud : MonoBehaviour, IClickable
{

    public bool IsPathing => !m_agent?.isStopped ?? false;

    [SerializeField]
    private Transform m_visualsParent = null;

    [SerializeField]
    private IntReference m_emoteIndex = null;

    private const double EXCITED_STATE_DURATION = 1.0;

    bool IClickable._IsFriendly => true;

    void IClickable._HandleClick()
    {
        m_happyTime = DateTime.UtcNow;
    }

    [SerializeField]
    private NavMeshAgent m_agent = null;

    [SerializeField]
    private FloatReference m_wobbleAmount = null;

    [SerializeField]
    private FloatReference m_wobbleSpeed = null;

    private Collider[] m_preAllocatedSphereHits = new Collider[10];

    private bool m_isScared = false;
    private DateTime? m_happyTime = null;
    private DateTime? m_excitedTime = null;
    private bool m_hasReachedGoal = false;

    public void SetPosition(Vector3 position)
    {
        m_agent.SetDestination(position);
        m_agent.isStopped = false;
        m_excitedTime = DateTime.UtcNow;
    }

    private void Update()
    {
        UpdateNavAgent();
        CharacterUtility.UpdateWobble(m_visualsParent, m_agent.desiredVelocity, m_wobbleSpeed, m_wobbleAmount, m_isScared);
        UpdateState();
        UpdateEmote();
        UpdateBounce();
        UpdateScale();

        m_agent.isStopped = m_isScared || m_hasReachedGoal;
    }

    private Transform FindPhysicsRoot(Transform transform)
    {
        var potentialRigidBody = transform.GetComponentInParent<Rigidbody>();
        if (potentialRigidBody != null)
        {
            return potentialRigidBody.transform;
        }

        return transform.root;
    }

    private void UpdateState()
    {
        m_isScared = false;
        var hits = Physics.OverlapSphereNonAlloc(transform.position, 2f, m_preAllocatedSphereHits);
        for (int i = 0; i < hits; i++)
        {
            var current = m_preAllocatedSphereHits[i];
            if (FindPhysicsRoot(current.transform).TryGetComponent(out Enemy enemy))
            {
                m_isScared = true;
                break;
            }
        }
    }

    private void UpdateEmote()
    {
        if (m_isScared)
        {
            m_emoteIndex.Value = (int)BudEmote.Scared;
            return;
        }

        if (m_happyTime.HasValue)
        {
            var elapsed = (DateTime.UtcNow - m_happyTime.Value).TotalSeconds;
            if (elapsed > 2.0)
            {
                m_happyTime = null;
            }

            m_emoteIndex.Value = (int)BudEmote.Happy;
            return;
        }

        if (m_excitedTime.HasValue)
        {
            var elapsed = (DateTime.UtcNow - m_excitedTime.Value).TotalSeconds;
            if (elapsed > EXCITED_STATE_DURATION)
            {
                m_excitedTime = null;
            }

            m_emoteIndex.Value = (int)BudEmote.Excited;
            return;
        }

        m_emoteIndex.Value = (int)BudEmote.None;
    }

    private void UpdateNavAgent()
    {
        m_hasReachedGoal = Vector3.Distance(m_agent.destination, transform.position) <= 0.1f;
    }

    private void UpdateBounce()
    {
        var normalOffset = new Vector3(0f, 0.5f, 0f);
        Vector3 finalPosition;
        if (m_excitedTime.HasValue && !m_isScared)
        {
            var elapsed = DateTime.UtcNow - m_excitedTime.Value;
            var elapsedT = elapsed.TotalSeconds / (EXCITED_STATE_DURATION * 0.3);
            var elapsedF = -4f * Mathf.Pow(((float)elapsedT) - 0.5f, 2f) + 1f;
            var targetOffset = normalOffset + new Vector3(0f, .25f, 0f);
            finalPosition = Vector3.Lerp(normalOffset, targetOffset, elapsedF);
        }
        else
        {
            finalPosition = Vector3.Lerp(m_visualsParent.localPosition, normalOffset, Time.deltaTime * 5f);
        }

        m_visualsParent.localPosition = finalPosition;
    }

    private void UpdateScale()
    {
        var targetScale = m_isScared ? new Vector3(1f, .2f, 1f) : Vector3.one;
        transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * 5f);
    }
}

public enum BudEmote
{
    None,
    Scared,
    Happy,
    Excited
}