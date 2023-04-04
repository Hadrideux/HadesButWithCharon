using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{
    [SerializeField] private int _minimum;
    [SerializeField] private int _maximum;
    [SerializeField] private int _current;
    [SerializeField] private Image _mask;
    //[SerializeField] private Image _fill;
    [SerializeField] private Color _color;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }

    private void GetCurrentFill()
    {
        float currentOffset = _current - _minimum;
        float maximumOffset = _maximum - _minimum;
        float fillAmount = currentOffset / maximumOffset;
        _mask.fillAmount = fillAmount;
        
        //_fill.color = _color;

    }
}
