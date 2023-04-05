using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDoor : MonoBehaviour
{

    [SerializeField] private EventController _eventController = null;

    [SerializeField] private int _breakCycleDuration = 0;
    [SerializeField] private bool _isBreak = false;

    [SerializeField] private int _leakCycleDuration = 0;
    [SerializeField] private bool _isLeak = false;
    
    public bool IsBreak
    {
        get => _isBreak;
        set => _isBreak = value;
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

    // soustraint une partie du cache du styx et les envoi vers le tartare
    public void LeakEvent()
    {
        if (_leakCycleDuration == 1)
        {

        }
        else if (_leakCycleDuration != 1)
        { 

        }
    }


}
