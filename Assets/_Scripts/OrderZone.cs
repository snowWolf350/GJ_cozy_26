using UnityEngine;
using System.Collections.Generic;
public class OrderZone : MonoBehaviour
{
    //recipeSO list

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
