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
    public GameObject buttonUp;
    public Stopwatch stopwatch;
    public TextMeshProUGUI gameTime;
    
    public void Start()
    {
        //isGameOverMenuOn = true;
        gameOverMenu.SetActive(true);
        
        //buttonUp.SetActive(false);
        //stopwatch.gameObject.SetActive(false);
        //gameTime.text = stopwatch.currentTimeText.text;
    }

    public void StartOver()
    {
        SceneManager.LoadScene(1);
        DataPersistenceManager.instance.LoadGame();
    }
}
