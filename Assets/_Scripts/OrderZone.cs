using UnityEngine;
using System.Collections.Generic;
using UnityEditor.Rendering;
public class OrderZone : MonoBehaviour
{
    //recipeSO list
    [SerializeField] RecipeListSO _recipeListSo;
    List<RecipesSO> _currentOrderList;

    float _orderDelayMin = 8;
    float _orderDelayMax = 15;
    float _orderDelay = 2;
    int maxOrders = 5;

    private void Awake()
    {
        _currentOrderList = new List<RecipesSO>();
    }

    private void Update()
    {
        if (_currentOrderList.Count >= maxOrders) return;

        _orderDelay -= Time.deltaTime;
        if (_orderDelay < 0)
        {
            //add a recipe
            SpawnOrder();
            //reset delay
            _orderDelay = Random.Range(_orderDelayMin, _orderDelayMax);
        }
    }

    void SpawnOrder()
    {
        _currentOrderList.Add(_recipeListSo._recipeList[Random.Range(0, _recipeListSo._recipeList.Count)]);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.TryGetComponent(out Order order))
        {
            //order has been delivered here
            foreach (RecipesSO recipesSO in _currentOrderList)
            {
                bool correctOrder = true ;
                // 1 recipe from the ones we want
                foreach (IngredientSO ingredientso in recipesSO._recipe)
                {
                    //1 ingredient that we want
                    //cycle throught the player's order to find this element
                    if (!correctOrder) break;
                    for (int i = 0; i < order.GetIngredientList().Count; i++)
                    {
                        if (order.OrderContains(ingredientso))
                        {
                            //order contains the needed ingredient
                            correctOrder = true;
                            break;
                        }
                        correctOrder = false;
                    }
                }
                if(correctOrder == true)
                {
                    Debug.Log("Correct delivery");
                }
                else
                {
                    Debug.Log("Wrong Delivery");
                }
            }

            Destroy(order.gameObject);
            //cycle through recipes 
            //if one doesnt match break
            //if all match delivered 
            //else not delivered
        }
    }
}
