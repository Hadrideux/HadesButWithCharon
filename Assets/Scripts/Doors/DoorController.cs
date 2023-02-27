using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private int[] _doorThresholds = null;
    private int _thresholds = 0;
    private int _index = 0;
    private bool _isSelected = false;

    #region Properties

    public int CurrentFlow => _doorThresholds[_index];

    public int CurrentTresholds
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
        if (_isSelected)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow)) //Increase Angle Door
            {
                Index++;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow)) //Decrease Angle Door
            {
                Index--;
            }
        }
    }
}