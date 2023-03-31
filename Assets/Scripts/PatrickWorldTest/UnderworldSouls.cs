using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderworldSouls : MonoBehaviour
{
    private ParticleSystem _underworldSoulFlow;
    [SerializeField] private UnderworldManager _underworldManager = null;
    [SerializeField] private DoorSouls _doorSouls = null;
    [SerializeField] private EventController _eventController = null;
    private float _underworldSoulsRate;
    public float UnderworldSoulsRate
    {
        get => _underworldSoulsRate;
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
        underworldEmission.rateOverTime = _doorSouls.OutputSouls;
        _underworldSoulsRate = underworldEmission.rateOverTime.constant;
        _eventController.UnderworldRate = _underworldSoulsRate;
    }
}
