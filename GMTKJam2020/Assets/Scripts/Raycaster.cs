using UnityAtoms.BaseAtoms;
using UnityEngine;

//$$
public interface IClickable
{
    bool _IsFriendly { get; }
    void _HandleClick();
}

public class Raycaster : MonoBehaviour
{

    [SerializeField]
    private Vector3Event m_onPositionClicked = null;

    [SerializeField]
    private Texture2D m_normalCursor = null;

    [SerializeField]
    private Texture2D m_attackCursor = null;

    [SerializeField]
    private Texture2D m_petCursor = null;

    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 100f, Color.red, .25f, true);
        var didHit = Physics.Raycast(ray, out RaycastHit hitInfo);
        IClickable hitClickable = null;
        Texture2D cursorTexture = m_normalCursor;
        if (didHit)
        {
            Debug.DrawRay(hitInfo.point, Vector3.up);
            if (hitInfo.transform.TryGetComponent(out hitClickable))
            {
                cursorTexture = hitClickable._IsFriendly ? m_petCursor : m_attackCursor;
            }
        }

        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);

        if (Input.GetMouseButtonDown(0))
        {
            if (didHit)
            {
                if (hitClickable != null)
                {
                    hitClickable._HandleClick();
                }
                else
                {
                    m_onPositionClicked.Raise(hitInfo.point);
                }
            }
        }
    }

}
