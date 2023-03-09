using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    private float speed;
    private int secondsToSpeedUp = 5;
    public CurrentDifficulty currentDifficulty;
    
    public GameObject threeBlockWall;
    public GameObject cornerWall;
    public GameObject pointWall;
    public GameObject tWall;

    private void Start()
    {
        speed = 0.1f;
        InvokeRepeating("IncreaseSpeed", secondsToSpeedUp, secondsToSpeedUp);
    }

    private void FixedUpdate()
    {
        //Resources.FindObjectsOfTypeAll<>()
        
        threeBlockWall.transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);
        cornerWall.transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);
        pointWall.transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);
        tWall.transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);
        
        //transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);
    }

    public void IncreaseSpeed()
    {
        speed += currentDifficulty.speedToIncrease;
        Debug.Log("Speed increased = " + speed);
    }
}
