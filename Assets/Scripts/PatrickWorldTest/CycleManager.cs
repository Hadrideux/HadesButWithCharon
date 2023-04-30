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
    [SerializeField] private EventTartare _eventTartare = null;
    [SerializeField] private bool _eventIsActivated = false;
    private float _randomMin = 10f;
    private float _randomMax = 15f;

    [SerializeField] private TextMeshProUGUI _eventAnnounce = null;

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
                int eventChoice = Random.Range(0, 100);
                _eventAnnounce.text = "";
                if (eventChoice < 80)
                {
                    _eventTartare.MutinyEvent();
                    _eventAnnounce.text = "Vos Démons sont en plein burnout, ils prépare un mutinerie";

                }
            }
            else
            {
                int eventChoice = Random.Range(0, 100);
                _eventAnnounce.text = "";

                if (eventChoice <= 50)
                {
                    _eventEarth.WarEvent();
                    _eventAnnounce.text = "Une Guerre se prépare chez les Humains";
                }
                else if (eventChoice > 50)
                {
                    _eventController.EarthRate = Random.Range (10f, 15.1f);
                    Debug.Log("reset to normal random");
                }

            }
        }
    }

    private void SetCacheAttribut()
    {
        _eventTartare.MutinyCache -= 5;
        _earthCache = _eventController.EarthRate;
        _styxCache = _eventController.StyxRate;
        _underworldCache = _eventController.UnderworldRate;
        _eventController.StyxRateCache = _doorSouls.StuckSouls;
    }
}
