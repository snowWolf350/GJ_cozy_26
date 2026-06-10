using UnityEngine;

[CreateAssetMenu(fileName = "IngredientSO", menuName = "Scriptable Objects/IngredientSO")]
public class IngredientSO : ScriptableObject
{
    public string ingredient_Name;
    public GameObject ingredient_Visual;
    public GameObject ingredient_Object;
    public Sprite ingredient_Image;
}
