using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ColorblindUISprites : MonoBehaviour
{
    [SerializeField] private Sprite _protanopiaImage = null;
    private Image _imageComponent1 = null;

    [SerializeField] private Sprite _deuteranopiaImage = null;
    private Image _imageComponent2 = null;
    void Start()
    {
        if(PlayerPrefs.GetInt("ToggleBool2") == 1)
        {
            _imageComponent1 = this.GetComponent<Image>();
            _imageComponent1.sprite = _protanopiaImage;
        }

        if (PlayerPrefs.GetInt("ToggleBool3") == 1)
        {
            _imageComponent2 = this.GetComponent<Image>();
            _imageComponent2.sprite = _deuteranopiaImage;
        }
    }
}