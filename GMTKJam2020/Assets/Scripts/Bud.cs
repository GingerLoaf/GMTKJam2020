using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.AI;

public class Bud : MonoBehaviour, IClickable
{

    [SerializeField]
    private Transform m_visualsParent = null;

    void IClickable._HandleClick()
    {
        Debug.Log(name);
    }

    [SerializeField]
    private NavMeshAgent m_agent = null;

    [SerializeField]
    private FloatReference m_wobbleAmount = null;

    [SerializeField]
    private FloatReference m_wobbleSpeed = null;

    public void SetPosition(Vector3 position)
    {
        m_agent.SetDestination(position);
    }

    private void Update()
    {
        if (m_agent.isStopped)
        {
            return;
        }

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