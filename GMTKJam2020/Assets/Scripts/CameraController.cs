using UnityAtoms.BaseAtoms;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField]
    private IntReference m_followSpeed = null;

    [SerializeField]
    private Transform m_target = null;

    private Vector3 m_cameraOffset = Vector3.zero;

    private void Start()
    {
        m_cameraOffset = transform.position - m_target.transform.position;
    }

    private void Update()
    {
        var target = m_target.transform.position + m_cameraOffset;
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * m_followSpeed.Value);
    }

}
