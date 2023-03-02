using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.PostProcessing;

public class SettingsMenu : MonoBehaviour
{
    #region Attributs
    [SerializeField] private GameObject _mainMenu = null;
    [SerializeField] private GameObject _settingsMenu = null;

    [SerializeField] private Toggle _fullScreenToggle = null;
    [SerializeField] private Slider _brightnessSlider = null;
    [SerializeField] private PostProcessProfile _brightness = null;
    [SerializeField] private PostProcessLayer _layer = null;
    private float _normalBrightness = 1;
    private AutoExposure _exposure;

    [SerializeField] private List<ResolutionIndex> _resolutions = new List<ResolutionIndex>();
    [SerializeField] private TMP_Text _resolutionsText = null;
    private int _selectedResolutions = 0;
    #endregion Attributs

    void Start()
    {
        _brightness.TryGetSettings(out _exposure);
        _brightnessSlider.value = _normalBrightness;
        SetBrightness(_brightnessSlider.value);

    }

    void Update()
    {

    }

    public void Back()
    {
        _mainMenu.SetActive(true);
        _settingsMenu.SetActive(false);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void ResolutionsInf()
    {
        _selectedResolutions--;
        if (_selectedResolutions < 0)
        {
            _selectedResolutions = 0;
        }
        SetResolutionText();
        SetResolution();
    }

    public void ResolutionSup()
    {
        _selectedResolutions++;
        if (_selectedResolutions > _resolutions.Count - 1)
        {
            _selectedResolutions = _resolutions.Count - 1;
        }
        SetResolutionText();
        SetResolution();
    }

    public void SetResolutionText()
    {
        _resolutionsText.text = _resolutions[_selectedResolutions].horizontal.ToString() + "x" + _resolutions[_selectedResolutions].vertical.ToString();
    }

    public void SetResolution()
    {
        Screen.SetResolution(_resolutions[_selectedResolutions].horizontal, _resolutions[_selectedResolutions].vertical, _fullScreenToggle.isOn);
    }

    public void SetBrightness(float value)
    {
        if(value != 0)
        {
            _exposure.keyValue.value = value;
        }
        else
        {
            _exposure.keyValue.value = _normalBrightness;
        }
    }
}

[System.Serializable]
public class ResolutionIndex
{
    public int horizontal;
    public int vertical;
}