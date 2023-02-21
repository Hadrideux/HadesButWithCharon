using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulBehavior : MonoBehaviour
{
    private ParticleSystem _soulFlow;
    [SerializeField] private EarthManager _earthManager = null;

    // Start is called before the first frame update
    void Start()
    {
        _soulFlow = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame

    void Update()
    {
        ParticleSystem.EmissionModule soulFlowEmission = _soulFlow.emission;
        soulFlowEmission.rateOverTime = _earthManager.HumanProductionRate;
    }
}
