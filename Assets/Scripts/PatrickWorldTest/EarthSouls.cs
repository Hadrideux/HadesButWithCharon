using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthSouls : MonoBehaviour
{
    private ParticleSystem _earthSoulFlow;
    [SerializeField] private EarthManager _earthManager = null;
    private float _earthSoulsRate = 5f;
    public float EarthSoulsRate
    {
        get => _earthSoulsRate;
    }

    // Start is called before the first frame update
    void Start()
    {
        _earthSoulFlow = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        ParticleSystem.EmissionModule soulFlowEmission = _earthSoulFlow.emission;
        soulFlowEmission.rateOverTime = _earthManager.HumanProductionRate;
        _earthSoulsRate = soulFlowEmission.rateOverTime.constant;
    }
}
