using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{
    [SerializeField] private EEventName _eventToCall = EEventName.BabyBoomEvent;
    [SerializeField] private EarthSouls _earthSouls = null;
    [SerializeField] private DoorSouls _doorSouls = null;
    [SerializeField] private UnderworldSouls _underworldSouls = null;

    private float _earthRate = 5f;
    [SerializeField]  private float _earthMaxCapacity = 20f;
    private float _styxRate = 2f;
    private float _styxRateCache = 0f;
    [SerializeField] private float _styxMaxCapacity = 15f;
    private float _underworldRate = 5f;
    [SerializeField] private float _underworldMaxCapacity = 10f;
    private int _cycleCount = 0;
    private float _timer = 0f;
    private float _delay = 10f;

    private bool _doorEvent;

    #region Properties

    public float StyxRateCache
    {
        get
        {
            return _styxRateCache;
        }
        set
        {
            _styxRateCache = value;
        }
    }

    public bool IsDoor
    {
        get
        {
            return _doorEvent;
        }
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
        

        
    }




}
