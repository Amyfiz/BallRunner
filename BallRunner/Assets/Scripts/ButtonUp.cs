using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonUp : MonoBehaviour
{
    //public EventTrigger eventTrigger;
    private bool isGoingUp = false;

    private void Update()
    {
        //eventTrigger.OnPointerDown(FindObjectOfType<PlayerController>().rigidbody.AddForce(transform.up * Time.fixedDeltaTime * 100f, ForceMode2D.Force));
        if (isGoingUp)
        {
            FindObjectOfType<PlayerController>().rigidbody
                .AddForce(transform.up * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
            //rigidbody.AddForce(transform.up * flyForce * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
        }
    }
    
    public void Up(bool _isGoingUp)
    {
        isGoingUp = _isGoingUp;
    }

    public void StartGame()
    {
        GameEventManager.instance.GameStart();
    }
}
