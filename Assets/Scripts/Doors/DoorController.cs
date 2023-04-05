using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private EventController _eventController = null;


    [SerializeField] private float[] _doorThresholds = null;
    [SerializeField] private float _thresholds = 0;
    private int _index = 0;
    private bool _isSelected = false;
    [SerializeField] private GameObject _leftDoorObject = null;
    [SerializeField] private GameObject _rightDoorObject = null;

    #region Properties

    public float CurrentFlow => _doorThresholds[_index];

    public float CurrentTresholds
    {
        get => _thresholds;
        set => _thresholds = Mathf.Clamp(value, 0, _doorThresholds.Length);
    }

    public bool IsSelected
    {
        get => _isSelected;
        set => _isSelected = value;
    }

    private int Index
    {
        get => _index;
        set => _index = Mathf.Clamp(value, 0, _doorThresholds.Length - 1);
    }

    #endregion Properties

    // Update is called once per frame
    void Update()
    {
        OpenDoor();
    }

    private void OpenDoor()
    {
        if (_isSelected && _eventController.DoorEvent.IsBreak == true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)) //Increase Angle Door
            {
                Index++;
                DoorAngle();
            }

            if (Input.GetKeyDown(KeyCode.DownArrow)) //Decrease Angle Door
            {
                Index--;
                DoorAngle();
            }
        }
    }

    private void DoorAngle()
    {
        _thresholds = _doorThresholds[Index];
        float newAngle = _doorThresholds[Index] * 90 / 100;
        Vector3 rotation = new Vector3(0, 0, newAngle);
        _leftDoorObject.transform.rotation = Quaternion.Euler(rotation);
        _rightDoorObject.transform.rotation = Quaternion.Euler(- rotation);
    }

}