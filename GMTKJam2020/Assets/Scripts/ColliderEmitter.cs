using UnityAtoms.BaseAtoms;
using UnityEngine;

public class ColliderEmitter : MonoBehaviour
{

    [SerializeField]
    private ColliderEventReference m_onTriggerEnter = null;

    [SerializeField]
    private ColliderEventReference m_onTriggerStay = null;

    [SerializeField]
    private ColliderEventReference m_onTriggerExit = null;

    private void OnTriggerEnter(Collider other)
    {
        m_onTriggerEnter?.Event?.Raise(other);
    }

    private void OnTriggerStay(Collider other)
    {
        m_onTriggerStay?.Event?.Raise(other);
    }

    private void OnTriggerExit(Collider other)
    {
        m_onTriggerExit?.Event?.Raise(other);
    }

}
