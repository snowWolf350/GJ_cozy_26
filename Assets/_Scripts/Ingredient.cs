using UnityEngine;
public class Ingredient : MonoBehaviour
{
    [SerializeField] IngredientSO ingredientSO;
    
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
    public IngredientSO GetIngredientSO()
    {
        return ingredientSO;
    }
}