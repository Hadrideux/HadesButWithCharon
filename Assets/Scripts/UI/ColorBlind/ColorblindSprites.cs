using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorblindSprites : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer = null;
    [SerializeField] private Sprite _protanopiaSprite = null;
    [SerializeField] private Sprite _deuteranopiaSprite = null;

    void Start()
    {
        if(PlayerPrefs.GetInt("ToggleBool2") == 1)
        {
            _spriteRenderer.sprite = _protanopiaSprite;
        }

        if (PlayerPrefs.GetInt("ToggleBool3") == 1)
        {
            _spriteRenderer.sprite = _deuteranopiaSprite;
        }
    }
}