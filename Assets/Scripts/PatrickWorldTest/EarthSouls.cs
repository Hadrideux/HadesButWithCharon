using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthSouls : MonoBehaviour
{
    private ParticleSystem _earthSoulFlow;
    [SerializeField] private EarthManager _earthManager = null;

    // Start is called before the first frame update
    void Start()
    {
        _earthSoulFlow = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
