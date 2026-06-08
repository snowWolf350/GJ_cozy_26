using Unity.VisualScripting;
using UnityEngine;
public class Cup : MonoBehaviour
{
    Vector3 mousePositionOffset;

    Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseEnter()
    {
        if (Player.Instance.GetHoveringCup() == this) return;

        Player.Instance.SetHoveringCup(this);
    }
    private void OnMouseExit()
    {
        Player.Instance.SetHoveringCup(null);
    }

    private void OnMouseDown()
    {
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }
    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + mousePositionOffset;
    }
}