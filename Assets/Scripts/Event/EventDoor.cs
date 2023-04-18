using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDoor : MonoBehaviour
{

    //[SerializeField] private EventController _eventController = null;

    [SerializeField] private int _breakCycleDuration = 0;
    [SerializeField] private bool _isBreak = false;

    [SerializeField] private int _leakCycleDuration = 0;
    [SerializeField] private bool _isLeak = false;
    
    private float _leakValue = 0;
    [SerializeField] private float _leakMinValue = 0;
    [SerializeField] private float _leakMaxValue = 5;

    public bool IsBreak
    {
        get => _isBreak;
        set => _isBreak = value;
    }

    public bool IsLeak
    {
        get => _isLeak; 
        set => _isLeak = value;
    }

    public float LeakValue
    {
        get => _leakValue; 
        set => _leakValue = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {      
    }

    // Bloque les controles de la porte pendant 1 cycle
    public void DoorBreakEvent()
    {
        if (_breakCycleDuration == 1)
        {
            IsBreak = true;
        }
        else if (_breakCycleDuration != 1) 
        {
            IsBreak = true;
        }
    }

    // soustrait une partie du cache du styx et les envoi vers le tartare
    public void LeakEvent()
    {
        if (_leakCycleDuration == 1)
        {
            IsLeak = true;
            LeakValue = Random.Range(_leakMinValue, _leakMaxValue);
        }
        else if (_leakCycleDuration != 1)
        { 
            IsLeak = false;
            LeakValue = 0;
        }
    }


}
