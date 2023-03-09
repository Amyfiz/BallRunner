using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject selectLevel;
    private bool levelsOn;

    public void Start()
    {
        levelsOn = false; 
        //selectLevel.SetActive(false);
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // public void ShowLevels()
    // {
    //     if (!levelsOn)
    //     {
    //         selectLevel.SetActive(!selectLevel.activeSelf);
    //     }
    // }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
