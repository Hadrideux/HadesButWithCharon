using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CycleManager : MonoBehaviour
{
    [SerializeField] private EventController _eventController = null;
    [SerializeField] private DoorSouls _doorSouls = null;
    [SerializeField] private EventEarth _eventEarth = null;
    [SerializeField] private EventDoor _eventDoor = null;
    [SerializeField] private EventUnderworld _eventUnderworld = null;
    [SerializeField] private bool _eventIsActivated = false;
    private float _randomMin = 10f;
    private float _randomMax = 15f;

    [SerializeField] private TextMeshProUGUI _eventAnnounce = null;
    [SerializeField] private GameObject _GameOverMenu = null;
    [SerializeField] private GameObject _warningStyxAlert = null;
    [SerializeField] private GameObject _warningUnderworldAlert = null;
    private bool _styxDefeatCondition = false;
    private bool _underworldDefeatCondition = false;

    public float RandomMin
    {
        get
        {
            return _randomMin;
        }
        set
        {
            _randomMin = value;
        }
    }
    public float RandomMax
    {
        get
        {
            return _randomMax;
        }
        set
        {
            _randomMax = value;
        }
    }

    #region Event Check
    /*private bool _eventMutiny = false;
    private bool _eventPandemy = false;
    private bool _eventWar = false;
    private bool _eventBabyBoom = false;
    private bool _eventDoorBreak = false;
    private bool _eventLeak = false;*/
    #endregion Event Check

    #region Status Cache
    private float _earthCache = 0f;
    private float _styxCache = 0f;
    private float _underworldCache = 0f;
    #endregion Status Cache

    private float _timer = 0f;
    [SerializeField] private float _delay = 10f;
    private int _cycleCount = 0;
    
    public float Timer
    {
        get
        {
            return _timer;
        }

    }

    public int CycleCount
    {
        get
        {
            return _cycleCount;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        NewCycle();
        _eventAnnounce.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
        _timer += Time.deltaTime;
        if (_timer > _delay)
        {
            _warningStyxAlert.SetActive(false);
            _warningUnderworldAlert.SetActive(false);
            NewCycle();
            _timer = 0f;
        }

    }

    private void NewCycle()
    {
        SetCacheAttribut();
        CheckAndCallEvent();
        _doorSouls.newUpdateSouls();
        _eventController.EarthRate = Random.Range(_randomMin, _randomMax);        
        _cycleCount++;


    }

    private void CheckAndCallEvent()
    {
        if(_eventIsActivated == true)
        {
            if (_styxCache > _eventController.StyxMaxCapacity)
            {
                _warningStyxAlert.SetActive(true);
                if (_styxDefeatCondition == true)
                {
                    GameOver();
                }
                _styxDefeatCondition = true;

                int eventChoice = Random.Range(0, 100);

                if (eventChoice < 30)
                {
                    _eventDoor.BreakEvent();
                }
                else if (eventChoice > 30 && eventChoice < 70)
                {
                    _eventDoor.LeakEvent();
                }
            }
            else if (_underworldCache > _eventController.UnderworldMaxCapacity)
            {
                _warningUnderworldAlert.SetActive(true);
                if (_underworldDefeatCondition == true)
                {
                    GameOver();
                }
                _underworldDefeatCondition = true;
                int eventChoice = Random.Range(0, 100);
                _eventAnnounce.text = "";
                if (eventChoice < 80)
                {
                    _eventUnderworld.MutinyEvent();
                    _eventAnnounce.text = "Your Demons are in full overwork, they prepare a mutiny";

                }
            }
            else
            {
                _styxDefeatCondition = false;
                _underworldDefeatCondition = false;

                int eventChoice = Random.Range(0, 100);
                _eventAnnounce.text = "";

                if (eventChoice <= 50)
                {
                    _eventEarth.WarEvent();
                    _eventAnnounce.text = "A War is brewing among Humans";
                }
                else if (eventChoice > 50)
                {
                    _eventController.EarthRate = Random.Range (10f, 15.1f);
                    
                }

            }
        }
    }

    private void SetCacheAttribut()
    {
        _eventUnderworld.MutinyCache -= 5;
        _earthCache = _eventController.EarthRate;
        _styxCache = _eventController.StyxRate;
        _underworldCache = _eventController.UnderworldRate;
        _eventController.StyxRateCache = _doorSouls.StuckSouls;
    }

    private void GameOver()
    {
        _GameOverMenu.SetActive(true);
        Time.timeScale = 1;
        

    }
}
