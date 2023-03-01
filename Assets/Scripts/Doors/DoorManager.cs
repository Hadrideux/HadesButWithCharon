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
        set => _doorIndex = Mathf.Clamp(value, 0, _doors.Length - 1);
    }

    public float TotalFlow => _totalFlow;

    private void Start()
    {
        _doors[DoorsIndex] = _doors[0];
    }

    // Update is called once per frame
    void Update()
    {        
        _totalFlow = 0;
        for (int i = 0; i < _doors.Length; i++)
        {
            _totalFlow += _doors[i].CurrentFlow;
        }        

        DoorsSelect();
    }

    private void DoorsSelect()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _doors[DoorsIndex].IsSelected = false;
            DoorsIndex++;
            _doors[DoorsIndex].IsSelected = true;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _doors[DoorsIndex].IsSelected = false;
            DoorsIndex--;
            _doors[DoorsIndex].IsSelected = true;
        }
    }
}
