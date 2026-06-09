using UnityEngine;

public class BottleDrop : MonoBehaviour
{
    [SerializeField] GameObject Cup_Visual;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered collider");
        if (collision.transform.TryGetComponent(out Cup cup))
        {
            //there is a cup dropped here
            Instantiate(Cup_Visual,transform.position,Quaternion.identity);
            cup.DestroySelf();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
