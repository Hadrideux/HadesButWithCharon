using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TestingWorldSystem : MonoBehaviour
{
    [SerializeField] private EarthSouls _earthSouls = null;
    [SerializeField] private DoorSouls _doorSouls = null;
    [SerializeField] private UnderworldSouls _underworldSouls = null;
    [SerializeField] private EventController _eventController = null;
    [SerializeField] private CycleManager _cycleManager = null;
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
    #region Cycle
    [SerializeField] private TMP_Text _cycleText = null;
    [SerializeField] private Image _cycleBarImage = null;
    #endregion Cycle
    #region Earth
    [SerializeField] private TMP_Text _earthText = null;
    [SerializeField] private Image _earthBarImage = null;
    #endregion Earth
    #region Styx
    [SerializeField] private TMP_Text _styxText = null;
    [SerializeField] private Image _styxBarImage = null;
    #endregion Styx
    #region Underworld
    [SerializeField] private TMP_Text _underworldText = null;
    [SerializeField] private Image _underworldBarImage = null;
    #endregion Underworld
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
        _cycleText.text = _cycleManager.CycleCount.ToString();

        _earthRatePourcent.text = (_eventController.EarthRate/ _eventController.EarthMaxCapacity*100).ToString("F1") + "%";
        _styxRatePourcent.text = (_eventController.StyxRate/ _eventController.StyxMaxCapacity*100).ToString("F1") + "%";
        _underworldRatePourcent.text = (_eventController.UnderworldRate/ _eventController.UnderworldMaxCapacity*100).ToString("F1") + "%";


        _cycleBarImage.fillAmount = _cycleManager.Timer / 10;

        _earthBarImage.fillAmount = Mathf.Lerp (_earthBarImage.fillAmount, (_eventController.EarthRate / _eventController.EarthMaxCapacity), Time.deltaTime*2);
        _styxBarImage.fillAmount = Mathf.Lerp (_styxBarImage.fillAmount, (_eventController.StyxRate / _eventController.StyxMaxCapacity), Time.deltaTime * 2);
        _underworldBarImage.fillAmount = Mathf.Lerp (_underworldBarImage.fillAmount, (_eventController.UnderworldRate / _eventController.UnderworldMaxCapacity), Time.deltaTime * 2);

        
    }

}
