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
    [SerializeField] private TMP_Text _styxRateText = null;
    [SerializeField] private TMP_Text _underworldRateText = null;
    [SerializeField] private TMP_Text _earthRatePourcent = null;
    [SerializeField] private TMP_Text _styxRatePourcent = null;
    [SerializeField] private TMP_Text _underworldRatePourcent = null;
    private float _earthRate; 
    private float _styxRate;
    private float _underworldRate;

[SerializeField] private float _doorOpening = 0.5f;
    private float _doorCumule = 2f;
    [SerializeField] private TMP_Text _cycleText = null;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        _earthRateText.text = (_eventController.EarthRate).ToString("F1");
        _styxRateText.text = (_eventController.StyxRate).ToString("F1");
        _underworldRateText.text = (_eventController.UnderworldRate).ToString("F1");
        _cycleText.text = _eventController.CycleCount.ToString();

        _earthRatePourcent.text = (_eventController.EarthRate/ _eventController.EarthMaxCapacity*100).ToString("F1") + "%";
        _styxRatePourcent.text = (_eventController.StyxRate/ _eventController.StyxMaxCapacity*100).ToString("F1") + "%";
        _underworldRatePourcent.text = (_eventController.UnderworldRate/ _eventController.UnderworldMaxCapacity*100).ToString("F1") + "%";



    }



}
