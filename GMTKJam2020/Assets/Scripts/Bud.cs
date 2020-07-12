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

    public void SetPosition(Vector3 position)
    {
        m_agent.SetDestination(position);
        m_agent.isStopped = false;
        m_excitedTime = DateTime.UtcNow;
    }

    private void Update()
    {
        UpdateNavAgent();
        UpdateWobble();
        UpdateState();
        UpdateEmote();
        UpdateBounce();
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

        m_agent.isStopped = m_isScared;
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
        if (Vector3.Distance(m_agent.destination, transform.position) <= 0.1f)
        {
            m_agent.isStopped = true;
        }
    }

    private void UpdateBounce()
    {
        var normalOffset = new Vector3(0f, 0.5f, 0f);
        Vector3 finalPosition;
        if (m_excitedTime.HasValue)
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

    private void UpdateWobble()
    {
        var angles = m_visualsParent.transform.localRotation;
        var normalizedDesiredVelocity = m_agent.desiredVelocity.normalized;

        Quaternion newRot = Quaternion.identity;
        if (normalizedDesiredVelocity.magnitude > 0f)
        {
            var eulerAngles = angles.eulerAngles;
            eulerAngles.z = Mathf.Sin(Time.time * m_wobbleSpeed) * m_wobbleAmount;
            newRot = Quaternion.Euler(eulerAngles * normalizedDesiredVelocity.magnitude);
        }
        else
        {
            newRot = Quaternion.Slerp(m_visualsParent.transform.localRotation, newRot, Time.deltaTime * 10f);
        }

        m_visualsParent.transform.localRotation = newRot;
    }
}

public enum BudEmote
{
    None,
    Scared,
    Happy,
    Excited
}