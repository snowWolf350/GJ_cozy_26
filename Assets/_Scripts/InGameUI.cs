using UnityEngine;

public class InGameUI : MonoBehaviour
{
    [SerializeField] GameObject _stallView;
    [SerializeField] GameObject _frontView;
    bool _frontViewBool = true;

    public void SwitchSides()
    {
        if (_frontViewBool)
        {
            _stallView.SetActive(true);
            _frontView.SetActive(false);
        }
        else
        {
            _stallView.SetActive(false);
            _frontView.SetActive(true);
        }
        _frontViewBool = !_frontViewBool;
    }
}
