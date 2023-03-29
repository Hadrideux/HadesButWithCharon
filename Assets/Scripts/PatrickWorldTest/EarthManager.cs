using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthManager : MonoBehaviour
{
    [SerializeField] private float _humanProdutionRate = 100;
    [SerializeField] private float _delay = 10f;
    private float _timer = 0f;

    public float HumanProductionRate
    {
        get => _humanProdutionRate;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _delay)
        {
            NewCycle();
            _timer = 0f;
        }
    }

    private void NewCycle()
    {
        _humanProdutionRate = Random.Range(10f, 15.1f);
    }

}

