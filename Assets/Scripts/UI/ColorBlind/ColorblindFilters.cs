using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorblindFilters : MonoBehaviour
{
    [SerializeField] private Toggle _none = null;
    [SerializeField] private Toggle _protanopia = null;
    [SerializeField] private Toggle _deuteranopia = null;

    void Start()
    {
        if(PlayerPrefs.GetInt("ToggleBool") == 1)
        {
            _none.isOn = true;
        }
        else
        {
            _none.isOn = false;
        }

        if (PlayerPrefs.GetInt("ToggleBool2") == 1)
        {
            _protanopia.isOn = true;
        }
        else
        {
            _protanopia.isOn = false;
        }

        if (PlayerPrefs.GetInt("ToggleBool3") == 1)
        {
            _deuteranopia.isOn = true;
        }
        else
        {
            _deuteranopia.isOn = false;
        }
    }

    void Update()
    {
        if(_none.isOn == true)
        {
            PlayerPrefs.SetInt("ToggleBool", 1);
        }
        else
        {
            PlayerPrefs.SetInt("ToggleBool", 0);
        }

        if (_protanopia.isOn == true)
        {
            PlayerPrefs.SetInt("ToggleBool2", 1);
        }
        else
        {
            PlayerPrefs.SetInt("ToggleBool2", 0);
        }

        if (_deuteranopia.isOn == true)
        {
            PlayerPrefs.SetInt("ToggleBool3", 1);
        }
        else
        {
            PlayerPrefs.SetInt("ToggleBool3", 0);
        }
    }
}
