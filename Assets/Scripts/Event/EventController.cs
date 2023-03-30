using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventController : MonoBehaviour
{
    [SerializeField] private EEventName _eventToCall = EEventName.BabyBoomEvent;

    private float _earthRate = 5f;
    private float _styxRate = 2f;
    private float _underworldRate = 5f;
    private int _cycleCount = 0;
    private float _timer = 0f;
    private float _delay = 10f;
    private float _humanProdutionRate = 10f;

    #region Properties
    public float EarthRate
    {
        get
        {
            return _earthRate;
        }

    }

    public float StyxRate
    {
        get
        {
            return _styxRate;
        }

    }

    public float UnderworldRate
    {
        get
        {
            return _underworldRate;
        }

    }

    public float CycleCount
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
        _humanProdutionRate = Random.Range(10f, 15.1f);
        _cycleCount++; 
    }

    private void PickRandomEvent()
    {


    }

}
