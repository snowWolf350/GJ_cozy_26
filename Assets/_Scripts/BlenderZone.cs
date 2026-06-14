using UnityEngine;

public class BlenderZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check fruits which have entered
        //blend them
        //make it ready after some seconds

        if (collision.transform.TryGetComponent(out Ingredient ingredients))
        {
            //player has put a fruit in here 

        }
    }
}
