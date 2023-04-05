using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTartare : MonoBehaviour
{

    [SerializeField] private EventController _eventController = null;

    [SerializeField] private int _mutinyCycle = 0;
    [SerializeField] private bool _isStopProduct = false;

    public bool IsStopProduct
    {
        get => _isStopProduct;
        set => _isStopProduct = value;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Empeche le cache d'humain du tartare de se vider pendant 1 cycle
    public void MutinyEvent()
    {
        if (_mutinyCycle == 1)
        {
            IsStopProduct = true;
        }
        else if (_mutinyCycle != 1)
        {
            IsStopProduct = false;
        }
    }

    
}
