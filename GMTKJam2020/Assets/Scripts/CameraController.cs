using System.Linq;
using UnityAtoms.BaseAtoms;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField]
    private IntReference m_followSpeed = null;

    [SerializeField]
    private GameObjectReference m_target = null;

    [SerializeField]
    private LayerMask m_wallMask = default;

    private void Start()
    {
        UpdateTransform(1f);
    }

    private void Update()
    {
        UpdateTransform(Time.deltaTime * m_followSpeed.Value);
    }

    private void UpdateTransform(float lerpAmount)
    {
        if (m_target?.Value == null)
        {
            return;
        }

        var target = m_target.Value.transform.position + ((m_target.Value.transform.forward * 6f) + (Vector3.up * 2f));
        //var target = m_target.Value.transform.TransformPoint(new Vector3(0f, 2f, 6f));
        transform.position = Vector3.Lerp(transform.position, target, lerpAmount);
        transform.LookAt(m_target.Value.transform);

        var directionToCameraFromPlayer = (transform.position - m_target.Value.transform.position).normalized;

        var hits = Physics.RaycastAll(m_target.Value.transform.position, directionToCameraFromPlayer, 5f, m_wallMask);
        if (hits.Length > 0)
        {
            var firstNonPlayerHit = hits.FirstOrDefault(h => !(h.transform.CompareTag("Player") || h.transform.CompareTag("Enemy")));
            if (firstNonPlayerHit.transform != null)
            {
                Camera.main.transform.position = firstNonPlayerHit.point;
            }
        }
    }

}
