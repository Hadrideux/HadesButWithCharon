using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField] private DoorController[] _doors = null;
    [SerializeField] private int _doorIndex = 0;
    [SerializeField] private float _totalFlow = 0;

    public int DoorsIndex
    {
        get => _doorIndex;
        set => _doorIndex = Mathf.Clamp(value, 0, _doors.Length);
    }

    public float TotalFlow => _totalFlow;

    // Update is called once per frame
    void Update()
    {
        _totalFlow = 0;
        for (int i = 0; i < _doors.Length - 1; i++)
        {
            _totalFlow += _doors[i].CurrentFlow;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _doors[DoorsIndex].IsSelected = false;
            DoorsIndex++;
            _doors[DoorsIndex].IsSelected = true;
            Debug.Log(_doors[DoorsIndex]);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _doors[DoorsIndex].IsSelected = false;
            DoorsIndex--;
            _doors[DoorsIndex].IsSelected = true;
            Debug.Log(_doors[DoorsIndex]);
        }
    }
}
