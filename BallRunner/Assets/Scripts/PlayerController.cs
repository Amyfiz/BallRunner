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
    
    private void Start()
    {
        GameStart();
        //GameEventManager.instance.onGameStart += GameStart;
    }

    private void OnDestroy()
    {
        //GameEventManager.instance.onGameStart -= GameStart;
    }

    public void GameStart()
    {
        GameEventManager.instance.GameStart();
        transform.position = new Vector3(3, -7, 0);
        Time.timeScale = 1;
    }

    void FixedUpdate()
    {
        if (isGoingUp)
        {
            FindObjectOfType<PlayerController>().rigidbody.AddForce(transform.up * flyForce * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            //rigidbody.AddForce(transform.up * flyForce * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
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
        DataPersistenceManager.instance.SaveGame();
        Time.timeScale = 0;
    }
}
