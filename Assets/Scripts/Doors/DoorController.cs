using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private float[] _doorThresholds = null;
    private int _index = 0;
    private bool _isSelected = false;

    public float CurrentFlow => _doorThresholds[_index];

    public bool IsSelected
    {
        get => _isSelected;
        set => _isSelected = true;
    }

    private int Index
    {
        get => _index;
        set => _index = Mathf.Clamp(value, 0, _doorThresholds.Length);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (_isSelected)
        {
            if (Input.GetKeyDown(KeyCode.A)) //Increase Angle Door
            {
                Index++;
            }

            if (Input.GetKeyDown(KeyCode.E)) //Decrease Angle Door
            {
                Index--;
            }
        }
    }
}