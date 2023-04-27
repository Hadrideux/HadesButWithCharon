using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private EventController _eventController = null;

    [SerializeField] private float[] _doorThresholds = null;
    [SerializeField] private float _thresholds = 0;
    private int _index = 0;

    [SerializeField] private GameObject _leftDoorObject = null;
    [SerializeField] private GameObject _rightDoorObject = null;

    #region Properties

    public float CurrentFlow => _doorThresholds[_index];

    public float CurrentTresholds
    {
        get => _thresholds;
        set => _thresholds = Mathf.Clamp(value, 0, _doorThresholds.Length);
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
        NewDoorTest();
    }

    private void OpenDoor()
    {
        if (true)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)) //Increase Angle Door
            {
                Index--;
                
            }

            if (Input.GetKeyDown(KeyCode.DownArrow)) //Decrease Angle Door
            {
                Index++;
                
            }
        }
    }

    private void DoorAngle()
    {
        _thresholds = _doorThresholds[Index];
        float newAngle = _doorThresholds[Index] * 90 / 100;
        Vector3 rotation = new Vector3(0, 0, newAngle);
        _leftDoorObject.transform.rotation = Quaternion.Euler(-rotation);
        _rightDoorObject.transform.rotation = Quaternion.Euler(rotation);

    }

    private void NewDoorTest()
    {
        _thresholds = _doorThresholds[Index];
        float newAngle = _doorThresholds[Index] * 90 / 100;
        Vector3 rotation = new Vector3(0, newAngle, 0);

        _leftDoorObject.transform.localRotation = Quaternion.Lerp(_leftDoorObject.transform.localRotation, Quaternion.Euler(-rotation), Time.deltaTime*4);
        _rightDoorObject.transform.localRotation = Quaternion.Lerp(_rightDoorObject.transform.localRotation, Quaternion.Euler(rotation), Time.deltaTime * 4);

        

    }

}