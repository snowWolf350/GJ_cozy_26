using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    Ingredient _hoveringCup;
    Ingredient _draggingCup;

    private void Awake()
    {
        Instance = this;
    }

    public Ingredient GetHoveringCup()
    {
        return _hoveringCup;
    }
    public void SetHoveringCup(Ingredient cupToSet)
    {
        _hoveringCup = cupToSet;
    }

    public void SetDraggingCup(Ingredient cupToSet)
    {
        _draggingCup = cupToSet;
    }


    public Ingredient GetDraggingCup()
    {
        return _draggingCup;
    }
}
