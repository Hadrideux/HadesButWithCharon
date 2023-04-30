using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMenu : MonoBehaviour
{
    #region Attributes
    [SerializeField] private GameObject _pauseMenu = null;
    [SerializeField] private GameObject _charon = null;
    [SerializeField] private GameObject _gameOver = null;
    private float _charonTimer = 10f;
    private bool _isCharonTimerEnd = false;
    private bool _isCharonTimerUseful = true;
    #endregion Attributes

    #region Methods
    private void Start()
    {
        _gameOver.SetActive(false);
        _charon.SetActive(false);
        _pauseMenu.SetActive(true);
    }

    private void Update()
    {
        OpenPauseMenu();
        GameOver();
        DisplayCharon();
        CharonTimer();


    }

    private void CharonTimer()
    {
        if(_isCharonTimerUseful == true)
        {
            if (GameOverMenu._isGameOverOpen == true)
            {
                _charon.SetActive(false);
            }
            _charonTimer -= Time.deltaTime;
            if (_charonTimer <= 0)
            {
                _isCharonTimerEnd = true;
                _isCharonTimerUseful = false;
            }
        }
    }

    private void OpenPauseMenu()
    {
        if(Input.GetKeyDown(KeyCode.P) && PauseMenu._isPauseMenuOpen == false)
        {
            _pauseMenu.SetActive(true);
            Time.timeScale = 1; //Desactivate managers
            _charon.SetActive(false);
            PauseMenu._isPauseMenuOpen = true;
        }
    }

    private void GameOver()
    {
        if(Input.GetKeyDown(KeyCode.G) && GameOverMenu._isGameOverOpen == false)
        {
            _gameOver.SetActive(true);
            _charon.SetActive(false);
            GameOverMenu._isGameOverOpen = true;
            //Desactivate managers
        }
    }

    private void DisplayCharon()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && (Input.GetKeyDown(KeyCode.DownArrow)) && _isCharonTimerEnd == true)
        {
            _charon.SetActive(true);
        }
    }
    #endregion Methods

}