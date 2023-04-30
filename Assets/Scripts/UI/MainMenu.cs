using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    #region Attributes
    [SerializeField] private GameObject _mainMenu = null;
    [SerializeField] private GameObject _settingsMenu = null;
    
    [SerializeField] private AudioSource _source = null;
    [SerializeField] private AudioClip _clip = null;
    #endregion Attributes

    #region Methods
    private void Start()
    {
        _mainMenu.SetActive(true);
        _settingsMenu.SetActive(false);
    }

    public void Play()
    {
        _source.PlayOneShot(_clip);
        SceneManager.LoadScene("GameScene");
    }

    public void Quit()
    {
        _source.PlayOneShot(_clip);
        Application.Quit();
    }

    public void OpenSettings()
    {
        _source.PlayOneShot(_clip);
        _mainMenu.SetActive(false);
        _settingsMenu.SetActive(true);
    }
    #endregion Methods
}