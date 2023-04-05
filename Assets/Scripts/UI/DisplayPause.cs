using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPause : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu = null;
    void Start()
    {
        
    }

    void Update()
    {
        OpenPauseMenu();
    }

    private void OpenPauseMenu()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && PauseMenu._isPauseMenuOpen == false)
        {
            _pauseMenu.SetActive(true);
            Time.timeScale = 1; //Désactiver les managers
            PauseMenu._isPauseMenuOpen = true;
        }
    }
}