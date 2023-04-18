using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTartare : MonoBehaviour
{
    [SerializeField] private EventController _eventController = null;

    [SerializeField] private float _mutinyCache = 0f;
    [SerializeField] private int _mutinyCycle = 0;

    public float MutinyCache
    {
        get => _mutinyCache;
        set => _mutinyCache = Mathf.Clamp(value,0 , 20);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Empeche le cache d'humain du tartare de se vider pendant 1 cycle
    public void MutinyEvent()
    {
        _mutinyCache = 20;           
    }    
}