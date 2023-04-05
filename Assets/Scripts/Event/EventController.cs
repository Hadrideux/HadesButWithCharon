using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{
    [SerializeField] private EventDoor _doorEvent = null;


    [SerializeField] private EEventName _eventToCall = EEventName.BabyBoomEvent;
    [SerializeField] private EarthSouls _earthSouls = null;
    [SerializeField] private DoorSouls _doorSouls = null;
    [SerializeField] private UnderworldSouls _underworldSouls = null;

    private float _earthRate = 5f;
    [SerializeField]  private float _earthMaxCapacity = 20f;
    private float _styxRate = 2f;
    [SerializeField] private float _styxMaxCapacity = 15f;
    private float _underworldRate = 5f;
    [SerializeField] private float _underworldMaxCapacity = 10f;
    private int _cycleCount = 0;
    private float _timer = 0f;
    private float _delay = 10f;

    #region Properties
    public EventDoor DoorEvent
    {
        get => _doorEvent;
        set => _doorEvent = value;
    }

    public float EarthRate
    {
        get
        {
            return _earthRate;
        }
        set
        {
            _earthRate = value;
        }
    }

    public float EarthMaxCapacity
    {
        get
        {
            return _earthMaxCapacity;
        }
        set
        {
            _earthMaxCapacity = value;
        }
    }

    public float StyxRate
    {
        get
        {
            return _styxRate;
        }

        set
        {
            _styxRate = value;
        }
    }

    public float StyxMaxCapacity
    {
        get
        {
            return _styxMaxCapacity;
        }

        set
        {
            _styxMaxCapacity = value;
        }
    }

    public float UnderworldRate
    {
        get
        {
            return _underworldRate;
        }
        set
        {
            _underworldRate = value;
        }
    }

    public float UnderworldMaxCapacity
    {
        get
        {
            return _underworldMaxCapacity;
        }
        set
        {
            _underworldMaxCapacity = value;
        }
    }

    public int CycleCount
    {
        get
        {
            return _cycleCount;
        }

    }

#endregion Properties

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
        _earthRate = Random.Range(10f, 15.1f);
        _cycleCount++; 
    }

    private void PickRandomEvent()
    {


    }

}
