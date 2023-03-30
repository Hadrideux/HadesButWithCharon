using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSouls : MonoBehaviour
{
    private ParticleSystem _doorSoulFlow;
    [SerializeField] private EarthManager _earthManager = null;
    [SerializeField] private EventController _eventController = null;
    [SerializeField] private ParticleSystem _earthSouls = null;
    [SerializeField] private DoorController _doorController = null;
    private float _stuckSouls = 0f;
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
        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            UpdateDoorSouls();
        }
    }

    private void UpdateDoorSouls()
    {
        _stuckSouls = _eventController.EarthRate - (_eventController.EarthRate * _doorController.CurrentTresholds / 100);
        ParticleSystem.EmissionModule doorEmission = _doorSoulFlow.emission;
        doorEmission.rateOverTime = _stuckSouls;
        _outputSouls = _eventController.EarthRate - _stuckSouls;

    }
}
