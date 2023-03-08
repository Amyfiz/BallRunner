using System;
using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private bool isGoingUp = false;
    public Rigidbody2D rigidbody;
    public float flyForce = 10f;
    public GameOverMenu gameOverMenu;
    public Stopwatch stopwatch;
    
    private void Start()
    {
        DataPersistenceManager.instance.LoadGame();
        Time.timeScale = 1;
        stopwatch.StartStopwatch();
    }

    void FixedUpdate()
    {
        if (isGoingUp)
        {
            rigidbody.AddForce(transform.up * flyForce * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
        }
    }

    public void OnTriggerEnter2D(Collider2D wall)
    {
        if (wall.tag == "Wall")
        {
            Death();
        }
    }

    public void Up(bool _isGoingUp)
    {
        isGoingUp = _isGoingUp;
    }

    public void Death()
    {
        GameEventManager.instance.PlayerDeath();
        stopwatch.StopStopwatch();
        gameOverMenu.gameObject.SetActive(true);
        DataPersistenceManager.instance.SaveGame();
        Time.timeScale = 0;
        
    }
}
