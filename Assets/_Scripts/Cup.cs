using UnityEngine;
public class Cup : MonoBehaviour
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