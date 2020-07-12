using UnityEngine;
using UnityEngine.AI;

public class Bud : MonoBehaviour, IClickable
{

    void IClickable._HandleClick()
    {
        Debug.Log(name);
    }

    [SerializeField]
    private NavMeshAgent m_agent = null;

    public void SetPosition(Vector3 position)
    {
        m_agent.SetDestination(position);
    }

}