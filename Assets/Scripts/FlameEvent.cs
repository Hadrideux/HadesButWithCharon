using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameEvent : MonoBehaviour
{
    [SerializeField] private GameObject _flames = null;
    [SerializeField] private ParticleSystem _flamesParticule = null;
    [SerializeField] private Transform _earth = null;
    [SerializeField] private Transform[] _spawnPos = null;

    [SerializeField] private AudioSource _source = null;
    [SerializeField] private AudioClip _click = null;

    void Start()
    {
        //int spawnPositionIndex = Random.Range(0, _spawnPos.Length);
        //Instantiate(_flames, _spawnPos[spawnPositionIndex].position, _earth.transform.rotation, _earth);
        _flamesParticule = _flames.GetComponent<ParticleSystem>();
    }
    void Update()
    {
        //SpawnFlames();
    }

    public void SpawnFlames()
    {
        int spawnPositionIndex = Random.Range(0, _spawnPos.Length);
        Instantiate(_flames, _spawnPos[spawnPositionIndex].position, _earth.transform.rotation, _earth);
        _source.loop = true;
        _source.Play();
        ParticleSystem.MainModule flameMainModule = _flamesParticule.main;
        flameMainModule.playOnAwake = true;
    }
}