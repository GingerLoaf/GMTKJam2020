using UnityAtoms.BaseAtoms;
using UnityEngine;

//$$
public interface IClickable
{
    void _HandleClick();
}

public class Raycaster : MonoBehaviour
{

    [SerializeField]
    private Vector3Event m_onPositionClicked = null;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, .25f, true);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.transform.TryGetComponent(out IClickable clickable))
                {
                    clickable._HandleClick();
                }
                else
                {
                    m_onPositionClicked.Raise(hitInfo.point);
                }

                Debug.DrawRay(hitInfo.point, Vector3.up);
            }
        }
    }

}
