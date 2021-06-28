using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;
using System;

public class MainUIController : MonoBehaviour
{
    #region Class
    private VibrationSwitching _vibrationSwitching = null;
    private Reset _reset = null;
    private ShopScript _shopScript = null;
    #endregion

    #region Reset
    [SerializeField, HeaderAttribute("リセットボタン")]
    private Button _resetBotton;
    #endregion

    #region Vibrate
    [SerializeField, HeaderAttribute("バイブレーション切り替えボタン")]
    private Button _vibrateBotton;

    [SerializeField]
    private Image _vibrateImage;

    public Sprite[] _vibrateSprite;
    private int _vibeBotton_swich = 0;
    #endregion

    #region Shop
    [SerializeField, HeaderAttribute("ショップボタン")]
    private Button _shopBotton;
    #endregion

    private void Start()
    {
        _vibrationSwitching = new VibrationSwitching(_vibrateImage, _vibrateSprite);
        _reset = new Reset();
        _shopScript = new ShopScript();
        SetUp();
    }

    private void SetUp()
    {
        _vibrateBotton.OnClickAsObservable()
           .Subscribe(_ => _vibrationSwitching.Switching())
           .AddTo(this);

        _resetBotton.OnClickAsObservable()
           .Subscribe(_ => _reset.DoReset())
           .AddTo(this);

        _shopBotton.OnClickAsObservable()
           .Subscribe(_ => _shopScript.LoadShop())
           .AddTo(this);
    }
}
