using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UnderworldSouls : MonoBehaviour
{
    [SerializeField] private EventUnderworld _eventUnderworld = null;
    private ParticleSystem _underworldSoulFlow;
    [SerializeField] private DoorSouls _doorSouls = null;
    [SerializeField] private EventController _eventController = null;
    private float _underworldSoulsRate;
    public float UnderworldSoulsRate
    {
        get => _underworldSoulsRate;
        set => _underworldSoulsRate = Mathf.Clamp(value, 0, float.MaxValue);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _underworldSoulFlow = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        ParticleSystem.EmissionModule underworldEmission = _underworldSoulFlow.emission;
        
        UnderworldSoulsRate = _eventUnderworld.MutinyCache + _doorSouls.OutputSouls;
        underworldEmission.rateOverTime = UnderworldSoulsRate;
        _eventController.UnderworldRate = _underworldSoulsRate;
    }
}
