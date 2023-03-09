using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UI;

public class TapToStartButton : MonoBehaviour
{
    private Button tapToStartButton;

    private void Start()
    {
        //GameEventManager.instance.onGameStart += StartGame;
    }

    private void OnDestroy()
    {
        //GameEventManager.instance.onGameStart -= StartGame;
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        Destroy(this.gameObject);
        //tapToStartButton.gameObject.SetActive(false);
        GameEventManager.instance.GameStart();
    }
}
