using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    //private bool isGameOverMenuOn;
    public GameObject gameOverMenu;
    //public GameObject buttonUp;
    public Stopwatch stopwatch;
    public DeathCount deathCount;
    public TextMeshProUGUI gameTime;
    public TextMeshProUGUI deaths;
    
    public void Start()
    {
        GameEventManager.instance.onGameStart += HideGameOverMenu;
        GameEventManager.instance.onPlayerDeath += ShowGameOverMenu;
    }

    public void OnDestroy()
    {
        GameEventManager.instance.onGameStart -= HideGameOverMenu;
        GameEventManager.instance.onPlayerDeath -= ShowGameOverMenu;
    }

    public void ShowGameOverMenu()
    {
        gameOverMenu.SetActive(true);
        gameTime.text = stopwatch.currentTimeText.text;
        deaths.text = deathCount.deathCountText.text;
    }
    
    public void HideGameOverMenu()
    {
        gameOverMenu.SetActive(false);
    }

    public void StartOver()
    {
        SceneManager.LoadScene(1);
        //DataPersistenceManager.instance.LoadGame();
    }
}
