using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventEarth : MonoBehaviour
{
    [SerializeField] private EventController _eventController = null;
    [SerializeField] private FlameEvent _flameEvent = null;
    private float _pandemyDeathValue = 0f;
    private int _pandemyCycleDuration = 3;

    private int _warCycleDuration = 3;
    private int _babyBoomDuration = 10;
    private int _babyBoomCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Augmente la production d'humain pendant x cycle d'une valeur fixe, en ajoutant la valeur précédente
    public void PandemyEvent()
    {
        _pandemyCycleDuration = Random.Range(2, 4);
        for (int i = 0; i < _pandemyCycleDuration; i++)
        {
            _eventController.EarthRate = _eventController.EarthRate + _pandemyDeathValue;
            i++;
        }
        
    }

    // augmente la production d'humain pendant x cycle d'une valeur aléatoire
    public void WarEvent()
    {
        StartCoroutine(WarEventCoroutine());


    }

    IEnumerator WarEventCoroutine()
    {
        _warCycleDuration = Random.Range(3, 6);
        for (int i = 0; i < _warCycleDuration; i++)
        {
            _eventController.EarthRate = Random.Range(20f, 25f);

            if (_warCycleDuration > 0)
            {
                _flameEvent.SpawnFlames();
            }

            yield return new WaitForSeconds(5f);
        }
    }

    // augmente ponctuellement la production d'humain, dans x cycle plus tard
    public void BabyBoomEvent()
    {
        for (_babyBoomCount = 0; _babyBoomCount < _eventController.CycleCount + _babyBoomDuration; _babyBoomCount++)
        {
            
        }
        if (_eventController.CycleCount == _eventController.CycleCount + _babyBoomDuration)
        {
            _eventController.EarthRate = Random.Range(30, 40);
            _babyBoomCount = 0;
        }     


    }
    

}
