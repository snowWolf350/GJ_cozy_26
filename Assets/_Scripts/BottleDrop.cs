using UnityEngine;

public class BottleDrop : MonoBehaviour
{
    [SerializeField] GameObject _orderTemplate;
    [SerializeField] GameObject _currentOrder;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered collider");
        if (collision.transform.TryGetComponent(out Cup cup))
        {
            if (_currentOrder == null)
            {
                //no order is here
                _currentOrder = Instantiate(_orderTemplate, transform.position, Quaternion.identity);
                _currentOrder.GetComponent<Draggable>().DisableDrag();
            }
            
            if(_currentOrder.GetComponent<Order>().TryaddIngredients(cup.GetIngredientSO()))
            {

            }
            Destroy(cup.gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //order taken out 
        Debug.Log("Exited trigger");
    }
}
