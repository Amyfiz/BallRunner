using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    private bool isGameOverMenuOn;
    public GameObject gameOverMenu;
    public GameObject buttonUp;
    public PlayerController player;
    
    public void Start()
    {
        isGameOverMenuOn = true;
        gameOverMenu.SetActive(true);
        buttonUp.SetActive(false);
    }
}
