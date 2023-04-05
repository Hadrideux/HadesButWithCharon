using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    #region Fields
    [SerializeField] private EventController _eventController = null;
    private Vector3 _beginPos = Vector3.zero;
    private Vector3 _endPos = Vector3.zero;
    [SerializeField] private RectTransform _fill = null;
    #endregion Fields


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateBar(int currentHp, int maxHp)
    {
        float perc = (float)currentHp / (float)maxHp;
        _beginPos.x = -_fill.rect.width;
        _fill.localPosition = Vector3.Lerp(_endPos, _beginPos, perc);
    }


}
