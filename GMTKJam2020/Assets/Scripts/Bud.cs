using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.AI;

public class Bud : MonoBehaviour
{

    [SerializeField]
    private NavMeshAgent m_agent = null;

    public void SetPosition(Vector3 position)
    {
        m_agent.SetDestination(position);
    }

}