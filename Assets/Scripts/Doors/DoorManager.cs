using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField] private DoorController _doors = null;
    //[SerializeField] private int _doorIndex = 0;
    [SerializeField] private float _totalFlow = 0;

    public float TotalFlow => _totalFlow;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {        
        _totalFlow = _doors.CurrentFlow;
    }
}
