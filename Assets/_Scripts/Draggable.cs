using UnityEngine;

public class Draggable : MonoBehaviour
{
    Vector3 mousePositionOffset;
    bool _isDragging = true;

    Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void Start()
    {
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }

    private void Update()
    {
        if (_isDragging)
        {
            transform.position = GetMouseWorldPosition() + mousePositionOffset;
        }
    }
    private void OnMouseDown()
    {
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
        if (_isDragging) return;
        _isDragging = true;
    }
    private void OnMouseUp()
    {
        _isDragging = false;
        Destroy(gameObject);
    }
    public void DisableDrag()
    {
        _isDragging = false;
    }
}
