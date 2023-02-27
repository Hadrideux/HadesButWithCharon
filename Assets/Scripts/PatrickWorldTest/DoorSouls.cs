using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSouls : MonoBehaviour
{
    private ParticleSystem _doorSoulFlow;
    [SerializeField] private EarthManager _earthManager = null;
    [SerializeField] private ParticleSystem _earthSouls = null;

    // Start is called before the first frame update
    void Start()
    {
        _doorSoulFlow = GetComponent<ParticleSystem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            ParticleSystem.EmissionModule doorEmission = _doorSoulFlow.emission;
            doorEmission.rateOverTime = _earthManager.HumanProductionRate;
        }    


    }

}
