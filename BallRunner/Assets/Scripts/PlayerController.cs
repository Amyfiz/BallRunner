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
    public Canvas canvas;
    
    private void Start()
    {
        //DataPersistenceManager.instance.LoadGame();
        transform.position = new Vector3(3, -7, 0);
        Time.timeScale = 1;
        // canvas.stopwatch.gameObject.SetActive(true);
        // canvas.buttonUp.gameObject.SetActive(true);
        // canvas.deathCount.gameObject.SetActive(true);
        canvas.gameObject.SetActive(true);
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
        stopwatch.StopStopwatch();
        GameEventManager.instance.PlayerDeath();
        DataPersistenceManager.instance.SaveGame();
        gameOverMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
