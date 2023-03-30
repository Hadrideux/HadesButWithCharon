using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestingWorldSystem : MonoBehaviour
{
    [SerializeField] private EarthSouls _earthSouls = null;
    [SerializeField] private DoorSouls _doorSouls = null;
    [SerializeField] private UnderworldSouls _underworldSouls = null;
    [SerializeField] private EventController _eventController = null;
    [SerializeField] private TMP_Text _earthRateText = null;
    private float _earthRate = 5f;
    [SerializeField] private TMP_Text _styxRateText = null;
    private float _styxRate = 2f;
    [SerializeField] private TMP_Text _underworldRateText = null;
    private float _underworldRate = 5f;
    [SerializeField] private float _doorOpening = 0.5f;
    private float _doorCumule = 2f;
    [SerializeField] private TMP_Text _cycleText = null;
    private int _cycleCount = 0;


    private float _delay = 3;
    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _earthRateText.text = _eventController.EarthRate.ToString();
        _styxRateText.text = _eventController.StyxRate.ToString();
        _underworldRateText.text = _eventController.UnderworldRate.ToString();
        _cycleText.text = _eventController.CycleCount.ToString();



        _timer += Time.deltaTime;
        if (_timer > _delay)
        {
            _earthRate = _underworldRate;
            _styxRate = _earthRate * _doorOpening;
            _underworldRate = _styxRate * 1.2f;
            _doorCumule = _earthRate - _styxRate;
            _timer = 0;
        }

        
    }



}
