using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private GameObject _tuto = null;
    void Start()
    {
        _tuto.SetActive(true);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _tuto.SetActive(false);
        }
    }
}
