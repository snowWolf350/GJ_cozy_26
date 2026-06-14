using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlenderZone : MonoBehaviour
{
    GameObject _currentBlendObject;
    [SerializeField] Button _blendButton;
    [SerializeField] List<IngredientSO> _allowedIngredients;
    bool _isBlending;
    float blendTime = 3;

    private void Awake()
    {
        _blendButton.onClick.AddListener(() =>
        {
            if (_currentBlendObject != null && _isBlending == false)
            {
                //something is there to blend
                StartCoroutine(StartBlend());
                _blendButton.gameObject.SetActive(false);
            }
        });
    }

    IEnumerator StartBlend()
    {
        Destroy(_currentBlendObject.transform.GetChild(0).gameObject);
        
        yield return new WaitForSeconds(blendTime);

        Debug.Log("Blending done");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //check fruits which have entered
        //blend them
        //make it ready after some seconds

        if (collision.transform.TryGetComponent(out Ingredient ingredients))
        {
            bool allowed = false;
            foreach (IngredientSO ingredientSO in _allowedIngredients)
            {
                if (ingredientSO == ingredients.GetIngredientSO())
                {
                    allowed = true; break;
                }
            }
            if (!allowed) return;

            //player has put a fruit in here 
            if (_currentBlendObject == null)
            {
                // new object placed to blend
                _currentBlendObject = new GameObject();
                _currentBlendObject.transform.parent = transform;
                _currentBlendObject.transform.localPosition = Vector3.zero;
                Instantiate(ingredients.GetIngredientSO().ingredient_Visual, _currentBlendObject.transform);
                _blendButton.gameObject.SetActive(true);
                Destroy(ingredients.gameObject);
            }
        }
    }
}
