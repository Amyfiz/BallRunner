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
    //public CircleCollider2D playerCollider;
    //public TilemapCollider2D wallsCollider;
    public GameObject gameOverMenu;
    
    
    private void Start()
    {
        
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
            Time.timeScale = 0;
            gameOverMenu.SetActive(true);
        }
    }

    public void Up(bool _isGoingUp)
    {
        isGoingUp = _isGoingUp;
    }
}
