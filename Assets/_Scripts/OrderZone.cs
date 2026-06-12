using UnityEngine;
using System.Collections.Generic;
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

            //cycle through recipes 
            //if one doesnt match break
            //if all match delivered 
            //else not delivered
        }
    }
}
