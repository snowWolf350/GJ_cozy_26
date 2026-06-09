using UnityEngine;
public class Cup : MonoBehaviour
{
    Vector3 mousePositionOffset;
    bool _isDragging  = true;

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
    private void OnMouseUp()
    {
        _isDragging = false;
        DestroySelf();
    }
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}