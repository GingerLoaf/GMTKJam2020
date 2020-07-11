using UnityAtoms.BaseAtoms;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField]
    private Vector3Event m_onPositionClicked = null;

    [SerializeField]
    private IntReference m_followSpeed = null;

    [SerializeField]
    private Transform m_target = null;

    [SerializeField]
    private GameObjectReference m_clickVFX = null;

    private Vector3 m_cameraOffset = Vector3.zero;

    private void Start()
    {
        m_cameraOffset = transform.position - m_target.transform.position;
        m_clickVFX.Value.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, .25f, true);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.transform.CompareTag("Player"))
                {
                    // TODO: Petting
                    return;
                }

                m_onPositionClicked.Raise(hitInfo.point);
                Debug.DrawRay(hitInfo.point, Vector3.up);

                m_clickVFX.Value.SetActive(false);
                m_clickVFX.Value.SetActive(true);
            }
        }

        var target = m_target.transform.position + m_cameraOffset;
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * m_followSpeed.Value);
    }

}
