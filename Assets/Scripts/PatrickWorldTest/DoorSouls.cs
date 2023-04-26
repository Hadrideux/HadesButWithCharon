using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSouls : MonoBehaviour
{
    [SerializeField] private EventDoor _doorEvent = null;

    private ParticleSystem _doorSoulFlow;
    [SerializeField] private EarthManager _earthManager = null;
    [SerializeField] private EventController _eventController = null;
    [SerializeField] private ParticleSystem _earthSouls = null;
    [SerializeField] private DoorController _doorController = null;
    private float _styxSouls = 10f;
    private float _stuckSouls = 0f;
    private float _stuckSoulsWithCache = 0f;
    private float _outputSouls = 0f;

    public float StuckSouls
    {
        get => _stuckSouls;
    }

    public float OutputSouls
    {
        get => _outputSouls;
    }
    // Start is called before the first frame update
    void Start()
    {
        _doorSoulFlow = GetComponent<ParticleSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateDoorSouls()
    {
        //_eventController.StyxRateCache = _stuckSouls;
        _stuckSouls = (_eventController.EarthRate * _doorController.CurrentTresholds / 100);
        _stuckSoulsWithCache = (_eventController.EarthRate * _doorController.CurrentTresholds / 100) + _eventController.StyxRateCache;
        ParticleSystem.EmissionModule doorEmission = _doorSoulFlow.emission;
        doorEmission.rateOverTime = _stuckSoulsWithCache;
        _outputSouls = _eventController.EarthRate - _stuckSouls;
        _eventController.StyxRate = _stuckSouls;

        if (_doorEvent.IsLeak == true)
        {
            _stuckSouls -= _doorEvent.LeakValue;
            _outputSouls += _doorEvent.LeakValue;
        }
    }


    public void newUpdateSouls()
    {
        //calcul
        _styxSouls = _eventController.EarthRate + _stuckSouls;
        _stuckSouls = _styxSouls - (_styxSouls * (_doorController.CurrentTresholds / 100));
        _outputSouls = _styxSouls - _stuckSouls;
        
        _eventController.StyxRate = _stuckSouls;

        //set des particules
        ParticleSystem.EmissionModule doorEmission = _doorSoulFlow.emission;
        doorEmission.rateOverTime = _stuckSouls;

    }

}
