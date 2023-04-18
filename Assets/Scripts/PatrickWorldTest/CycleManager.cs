using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleManager : MonoBehaviour
{
    [SerializeField] private EventController _eventController = null;
    [SerializeField] private DoorSouls _doorSouls = null;
    [SerializeField] private EventEarth _eventEarth = null;
    [SerializeField] private EventDoor _eventDoor = null;
    [SerializeField] private EventTartare _eventTartare = null;

    #region Event Check
    private bool _eventMutiny = false;
    private bool _eventPandemy = false;
    private bool _eventWar = false;
    private bool _eventBabyBoom = false;
    private bool _eventDoorBreak = false;
    private bool _eventLeak = false;
    #endregion Event Check

    #region Status Cache
    private float _earthCache = 0f;
    private float _styxCache = 0f;
    private float _underworldCache = 0f;
    #endregion Status Cache

    private float _timer = 0f;
    private float _delay = 10f;
    private int _cycleCount = 0;
    
    public float Timer
    {
        get
        {
            return _timer;
        }

    }

    public int CycleCount
    {
        get
        {
            return _cycleCount;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        _timer += Time.deltaTime;
        if (_timer > _delay)
        {
            NewCycle();
            _timer = 0f;
        }

    }

    private void NewCycle()
    {
        SetCacheAttribut();
        CheckAndCallEvent();
        _eventController.EarthRate = Random.Range(10f, 15.1f);
        _eventController.StyxRateCache = 
        _cycleCount++;

    }

    private void CheckAndCallEvent()
    {

        if (_styxCache > _eventController.StyxMaxCapacity)
        {
            Random.Range(0, 100);
            
            Debug.Log("event du styx");
            
        }

        if (_underworldCache > _eventController.UnderworldMaxCapacity)
        {
            Debug.Log("event de l'underworld");

        }



    }

    private void SetCacheAttribut()
    {
        _earthCache = _eventController.EarthRate;
        _styxCache = _eventController.StyxRate;
        _underworldCache = _eventController.UnderworldRate;
    }
}
