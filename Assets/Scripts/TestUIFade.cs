using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestUIFade : MonoBehaviour
{
    [SerializeField] private TMP_Text _text = null;
    [SerializeField] private AnimationClip _fadeIn = null;
    [SerializeField] private AnimationClip _fadeOut = null;
    private Color _textColor;
    private int _count = 0;
    private bool _isVisible = false;

    void Start()
    {
        _textColor = _text.color;
    }

    void Update()
    {
        /*if(Input.GetKeyDown(KeyCode.Space))
        {
            _count++;
        }
        if(_count >= 3)
        {
            if(_isVisible == true)
            {
                _textColor.a -= Time.deltaTime;
                _text.color = _textColor;
                _isVisible = false;
            }
            else
            {
                _textColor.a += Time.deltaTime;
                _text.color = _textColor;
                _isVisible = true;
            }
        }*/
        if (_isVisible == true)
        {
            _textColor.a -= Time.deltaTime;
            _text.color = _textColor;
            _isVisible = false;
        }
        else
        {
            _textColor.a += Time.deltaTime;
            _text.color = _textColor;
            _isVisible = true;
        }
        Debug.Log(_textColor.a);
    }
}
