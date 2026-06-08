using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    Cup _hoveringCup;
    Cup _draggingCup;

    private void Awake()
    {
        Instance = this;
    }

    public Cup GetHoveringCup()
    {
        return _hoveringCup;
    }
    public void SetHoveringCup(Cup cupToSet)
    {
        _hoveringCup = cupToSet;
    }

    public void SetDraggingCup(Cup cupToSet)
    {
        _draggingCup = cupToSet;
    }


    public Cup GetDraggingCup()
    {
        return _draggingCup;
    }
}
