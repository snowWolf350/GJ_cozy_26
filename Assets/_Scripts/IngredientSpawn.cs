using UnityEngine;

public class IngredientSpawn : MonoBehaviour
{
    [SerializeField] IngredientSO ingredientSO;
    private void OnMouseDown()
    {
        //spawn a bottle and give player
        Instantiate(ingredientSO.ingredient_Object,transform.position,Quaternion.identity);
    }
}
