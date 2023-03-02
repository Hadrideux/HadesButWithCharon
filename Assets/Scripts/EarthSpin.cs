using UnityEngine;
using System.Collections;

public class EarthSpin : MonoBehaviour {
    [SerializeField] private float speed = 10f;

    void Update() {
        transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
    }
}