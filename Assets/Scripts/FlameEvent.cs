using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameEvent : MonoBehaviour
{
    [SerializeField] private GameObject _flames = null;
    [SerializeField] private Transform _earth = null;
    [SerializeField] private Transform[] _spawnPos = null;

    void Start()
    {
        int spawnPositionIndex = Random.Range(0, _spawnPos.Length);
        Instantiate(_flames, _spawnPos[spawnPositionIndex].position, _earth.transform.rotation, _earth);
    }
    void Update()
    {
        //SpawnFlames();
    }

    public void SpawnFlames()
    {
        int spawnPositionIndex = Random.Range(0, _spawnPos.Length);
        Instantiate(_flames, _spawnPos[spawnPositionIndex].position, _earth.transform.rotation, _earth);
    }
}