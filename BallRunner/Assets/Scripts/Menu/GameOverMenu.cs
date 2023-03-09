using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverMenu;
    //public Stopwatch stopwatch;
    //public DeathCount deathCount;
    //public TextMeshProUGUI stopwatchText;
    //public TextMeshProUGUI deathCountText;
    
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
        
        //stopwatchText.text = stopwatch.currentTimeText.text;
        //deathCountText.text = deathCount.deathCountText.text;
        
        //stopwatch.gameObject.SetActive(false);
        //deathCount.gameObject.SetActive(false);
        
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
