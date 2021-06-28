using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VibrationSwitching : MonoBehaviour
{
    private Image _image;

    private Sprite[] _sprite;

    private int _vibeBotton_swich = 0;

    public VibrationSwitching(Image image, Sprite[] sprite)
    {
        _image = image;
        _sprite = sprite;

        _vibeBotton_swich = PlayerPrefs.GetInt("Vibe");
        PlayerPrefs.SetInt("Vibe", _vibeBotton_swich);
        if (_vibeBotton_swich == 0)
            _image.sprite = _sprite[0];
        else if (_vibeBotton_swich == 1)
            _image.sprite = _sprite[1];
    }

    public void Switching()
    {
        if (_vibeBotton_swich == 0)
        {
            _vibeBotton_swich = 1;
            _image.sprite = _sprite[1];
        }
        else if (_vibeBotton_swich == 1)
        {
            _vibeBotton_swich = 0;
            _image.sprite = _sprite[0];
        }

        PlayerPrefs.SetInt("Vibe", _vibeBotton_swich);
    }
}
