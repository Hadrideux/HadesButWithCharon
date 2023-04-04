using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPController : MonoBehaviour
{
    [SerializeField] private int _maxHp = 100;
    private int _currentHp = 80;

    private event Action <int, int> _onHpChange = null;
    public event Action <int, int> OnHpChange
    {
        add
        {
            _onHpChange -= value;
            _onHpChange += value;
        }
        remove
        {
            _onHpChange -= value;
        }
    }

    public int Hp
    {

        get
        {
            return _currentHp;
        }
        set
        {
            _currentHp = Mathf.Clamp(value, 0, _maxHp);
            _onHpChange(_currentHp, _maxHp);
        }


    }
    private void Start()
    {
        _currentHp = _maxHp;


    }

    private void OnDestroy()
    {


    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Hp--;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Hp++;
        }

    }


}
