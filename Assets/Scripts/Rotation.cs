using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _rotSpeed = 20;


    void Update()
    {
        
    }
    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * _rotSpeed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.up, -rotX);
    }
}
