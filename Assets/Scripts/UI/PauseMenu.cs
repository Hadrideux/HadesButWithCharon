using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    #region Attributs
    [SerializeField] private GameObject _pauseMenu = null;
    [SerializeField] private GameObject _settingsMenu = null;
    [SerializeField] private GameObject _quitMainMenu = null;
    [SerializeField] private GameObject _quitDesktop = null;
    [SerializeField] private AnimationClip _appearAnim = null;
    [SerializeField] private AnimationClip _disappearAnim = null;
    [SerializeField] private Animator _quitMainMenuAnimator = null;
    [SerializeField] private Animator _quitDesktopAnimator = null;
    [SerializeField] private Animator _blackFadeIn = null;

    public static bool _isPauseMenuOpen = false;

    [SerializeField] private AudioSource _source = null;
    [SerializeField] private AudioClip _click = null;
    [SerializeField] private AudioClip _hold = null;

    #endregion Attributs

    void Start()
    {
        _pauseMenu.SetActive(false);
        _settingsMenu.SetActive(false);
        _quitMainMenu.SetActive(false);
        _quitDesktop.SetActive(false);
    }

    public void Resume()
    {
        _source.PlayOneShot(_click);
        _pauseMenu.SetActive(false);
        _settingsMenu.SetActive(false);
        _isPauseMenuOpen=false;
    }
    public void OpenSettings()
    {
        _source.PlayOneShot(_click);
        _pauseMenu.SetActive(false);
        _settingsMenu.SetActive(true);
    }

    public void Quit()
    {
        _source.PlayOneShot(_click);
        _quitMainMenu.SetActive(true);
        _quitDesktop.SetActive(true);
        _quitMainMenuAnimator.Play("Appear");
        _quitDesktopAnimator.Play("Appear");

    }

    public void QuitToMainMenu()
    {
        _source.PlayOneShot(_click);
        PauseMenu._isPauseMenuOpen = false;
        SceneManager.LoadScene("MainMenuScene");
    }
    public void QuitToDesktop()
    {
        _source.PlayOneShot(_click);
        //_blackFadeIn.Play("FadeIn");
        Application.Quit();
    }
}