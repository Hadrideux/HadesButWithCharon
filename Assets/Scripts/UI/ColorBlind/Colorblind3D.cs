using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorblind3D : MonoBehaviour
{
    [SerializeField] private Renderer _renderer = null;
    [SerializeField] private Material _protanopiaMaterial = null;
    [SerializeField] private Material _deuteranopiaMaterial = null;

    void Start()
    {
        if (PlayerPrefs.GetInt("ToggleBool2") == 1)
        {
            _renderer.material = _protanopiaMaterial;
        }

        if (PlayerPrefs.GetInt("ToggleBool3") == 1)
        {
            _renderer.material = _deuteranopiaMaterial;
        }
    }
}
