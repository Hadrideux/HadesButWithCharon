using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulBehavior : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = transform.forward;
        transform.position += dir.normalized * _speed * Time.deltaTime;
        
    }
}
