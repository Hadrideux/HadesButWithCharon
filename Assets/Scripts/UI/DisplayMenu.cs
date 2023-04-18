using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu = null;
    [SerializeField] private GameObject _charon = null;
    [SerializeField] private GameObject _years = null;
    [SerializeField] private GameObject _gameOver = null;
    void Start()
    {
        _gameOver.SetActive(false);
        _charon.SetActive(true);
        _years.SetActive(true);
        _pauseMenu.SetActive(true);
    }

    void Update()
    {
        OpenPauseMenu();
        GameOver();

        if(GameOverMenu._isGameOverOpen == true)
        {
            _charon.SetActive(false);
            _years.SetActive(false);
        }
    }

    private void OpenPauseMenu()
    {
        if(Input.GetKeyDown(KeyCode.P) && PauseMenu._isPauseMenuOpen == false)
        {
            _pauseMenu.SetActive(true);
            Time.timeScale = 1; //Désactiver les managers
            _charon.SetActive(false);
            _years.SetActive(false);
            PauseMenu._isPauseMenuOpen = true;
        }
    }

    private void GameOver()
    {
        if(Input.GetKeyDown(KeyCode.G) && GameOverMenu._isGameOverOpen == false)
        {
            _gameOver.SetActive(true);
            _charon.SetActive(false);
            _years.SetActive(false);
            GameOverMenu._isGameOverOpen = true;
            //désactiver les managers
        }
    }
}