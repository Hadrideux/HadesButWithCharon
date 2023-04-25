using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UnderworldSouls : MonoBehaviour
{
    [SerializeField] private EventTartare _eventTartare = null;
    private ParticleSystem _underworldSoulFlow;
    [SerializeField] private UnderworldManager _underworldManager = null;
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
        
        UnderworldSoulsRate = _eventTartare.MutinyCache + _doorSouls.OutputSouls;
        underworldEmission.rateOverTime = UnderworldSoulsRate;
        _eventController.UnderworldRate = _underworldSoulsRate;
    }
}
