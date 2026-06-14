using UnityEngine;

public class BottleDrop : MonoBehaviour
{
    [SerializeField] GameObject _orderTemplate;
    [SerializeField] GameObject _currentOrder;
    [SerializeField] GameObject _stallGO;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.TryGetComponent(out Ingredient cup))
        {
            if (_currentOrder == null)
            {
                //no order is here
                _currentOrder = Instantiate(_orderTemplate, transform.position, Quaternion.identity);
                _currentOrder.transform.parent = _stallGO.transform; 
                _currentOrder.GetComponent<Draggable>().DisableDrag();
            }
            
            if(_currentOrder.GetComponent<Order>().TryaddIngredients(cup.GetIngredientSO()))
            {

            }
            Destroy(cup.gameObject);
        }
    }
    
}
