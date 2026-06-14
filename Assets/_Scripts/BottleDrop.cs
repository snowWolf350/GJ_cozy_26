using UnityEngine;
using System.Collections.Generic;

public class BottleDrop : MonoBehaviour
{
    [SerializeField] GameObject _orderTemplate;
    [SerializeField] GameObject _currentOrder;
    [SerializeField] GameObject _stallGO;
    [SerializeField] List<IngredientSO> _allowedIngredients;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.TryGetComponent(out Ingredient ingredient))
        {
            bool allowed = false;
            foreach (IngredientSO ingredientSO in _allowedIngredients)
            {
                if(ingredientSO == ingredient.GetIngredientSO())
                {
                    allowed = true; break;
                }
            }
            if (!allowed) return;

            if (_currentOrder == null)
            {
                //no order is here
                _currentOrder = Instantiate(_orderTemplate, transform.position, Quaternion.identity);
                _currentOrder.transform.parent = _stallGO.transform; 
                _currentOrder.GetComponent<Draggable>().DisableDrag();
            }
            
            if(_currentOrder.GetComponent<Order>().TryaddIngredients(ingredient.GetIngredientSO()))
            {

            }
            Destroy(ingredient.gameObject);
        }
    }
    
}
