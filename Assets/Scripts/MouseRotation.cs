using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{
    [SerializeField] private float _rotSpeed = 20;


    void Update()
    {
        
    }

    [System.Obsolete]
    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * _rotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
        //transform.RotateAround(Vector3.up, -rotX);
    }
}
