using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    int _stage = 0;
    public void DoReset()
    {
        PlayerPrefs.SetInt("Player", 1);
        _stage = PlayerPrefs.GetInt("stage");
        SceneManager.LoadScene("MainStage" +_stage);
    }
}
