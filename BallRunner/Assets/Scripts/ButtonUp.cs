using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonUp : MonoBehaviour
{
    private bool isGoingUp = false;
    private bool isGameStarted = false;

    private void Update()
    {
        if (isGoingUp)
        {
            FindObjectOfType<PlayerController>().rigidbody
                .AddForce(transform.up * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
        }
    }
    
    public void Up(bool _isGoingUp)
    {
        isGoingUp = _isGoingUp;
    }

    // public void StartGame()
    // {
    //     if (!isGameStarted)
    //     {
    //         GameEventManager.instance.GameStart();
    //     }
    //
    //     isGameStarted = true;
    // }
}
