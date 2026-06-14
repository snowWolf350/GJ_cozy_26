using UnityEngine;
using System.Collections.Generic;

public class Order : MonoBehaviour
{
    List<IngredientSO> _ingredientList;

    private void Awake()
    {
        _ingredientList = new List<IngredientSO>();
    }

    public bool TryaddIngredients(IngredientSO ingredientSO)
    {
        if (_ingredientList.Contains(ingredientSO)) return false;

        Instantiate(ingredientSO.ingredient_Visual, transform);
        _ingredientList.Add(ingredientSO);
        return true;
        
    }

    public List<IngredientSO> GetIngredientList()
    {
        return _ingredientList;
    }

    public bool OrderContains(IngredientSO ingredient)
    {
        if (_ingredientList.Contains(ingredient))
        {
            return true;
        }
        return false;
    }
}
