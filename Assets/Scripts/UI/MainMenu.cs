using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu = null;
    [SerializeField] private GameObject _settingsMenu = null;
    void Start()
    {
        _mainMenu.SetActive(true);
        _settingsMenu.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene("Demo_LowPolyEarth");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OpenSettings()
    {
        _mainMenu.SetActive(false);
        _settingsMenu.SetActive(true);
    }
}
