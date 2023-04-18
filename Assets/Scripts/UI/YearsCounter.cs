using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class YearsCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _yearsText = null;
    private float _years;
    void Start()
    {
        
    }

    void Update()
    {
        //_years += Time.deltaTime;
        //_yearsText.text = _years.ToString() + " years";
    }
}
