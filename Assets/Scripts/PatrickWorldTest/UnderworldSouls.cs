using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnderworldSouls : MonoBehaviour
{
    private ParticleSystem _underworldSoulFlow;
    [SerializeField] private UnderworldManager _underworldManager = null;

    // Start is called before the first frame update
    void Start()
    {
        _underworldSoulFlow = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
