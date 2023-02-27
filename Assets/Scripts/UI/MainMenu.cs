using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _title = null;
    [SerializeField] private GameObject _mainMenu = null;
    [SerializeField] private GameObject _settingsMenu = null;
    [SerializeField] private GameObject _video = null;
    void Start()
    {
        _title.SetActive(true);
        _mainMenu.SetActive(true);
        _settingsMenu.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene("VirgileScene");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OpenSettings()
    {
        _title.SetActive(false);
        _mainMenu.SetActive(false);
        _settingsMenu.SetActive(true);
        _video.SetActive(true);
    }
}
