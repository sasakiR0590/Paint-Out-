using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ShopScript : MonoBehaviour
{
    public void LoadShop()
    {
        Debug.Log("ボタンが押されたよ");
        SceneManager.LoadScene("ShopScene");
    }
}
