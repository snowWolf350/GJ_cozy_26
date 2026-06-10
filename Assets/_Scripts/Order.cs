using UnityEngine;
using System.Collections.Generic;

public class Order : MonoBehaviour
{
    List<IngredientSO> _ingredientList;

    private void Awake()
    {
        _ingredientList = new List<IngredientSO>();
    }

    public void AddIngredients(IngredientSO ingredientSO)
    {
        Instantiate(ingredientSO.ingredient_Visual, transform);
        _ingredientList.Add(ingredientSO);
    }
}
