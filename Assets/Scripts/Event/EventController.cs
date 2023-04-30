using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{

    private float _earthRate = 5f;
    [SerializeField]  private float _earthMaxCapacity = 20f;
    private float _styxRate = 2f;
    private float _styxRateCache = 0f;
    [SerializeField] private float _styxMaxCapacity = 15f;
    private float _underworldRate = 5f;
    [SerializeField] private float _underworldMaxCapacity = 10f;
    private int _cycleCount = 0;

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

}
