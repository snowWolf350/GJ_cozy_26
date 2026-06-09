using UnityEngine;

public class GlassSpawn : MonoBehaviour
{
    [SerializeField] GameObject _Cupr_GO;
    private void OnMouseDown()
    {
        //spawn a bottle and give player
        Instantiate(_Cupr_GO,transform.position,Quaternion.identity);
    }
}
