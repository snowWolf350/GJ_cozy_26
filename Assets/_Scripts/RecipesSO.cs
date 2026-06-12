using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "RecipesSO", menuName = "Scriptable Objects/RecipesSO")]
public class RecipesSO : ScriptableObject
{
    public string _recipeName;
    public List<IngredientSO> _recipe;
}
