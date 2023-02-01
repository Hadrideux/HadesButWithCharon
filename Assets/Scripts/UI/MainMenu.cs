using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _title = null;
    [SerializeField] private GameObject _mainMenu = null;
    [SerializeField] private GameObject _settingsMenu = null;

    void Start()
    {
        _title.SetActive(true);
        _mainMenu.SetActive(true);
        _settingsMenu.SetActive(false);
    }

    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("GameScene");
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
    }
}
