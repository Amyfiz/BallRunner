using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameSpawner : MonoBehaviour
{
    //public GameObject framePrefab;
    private ObjectPooler objectPooler;
    private float speed;
    public GameObject starterPoint;
    
    public int secondsToSpeedUp;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
        speed = 0.1f;
        //SpawnFrame();
        objectPooler.SpawnFromPool("Frame", starterPoint.transform.position, Quaternion.identity);


        InvokeRepeating("IncreaseSpeed", secondsToSpeedUp, secondsToSpeedUp);
        InvokeRepeating("SpawnFrame", 0, 1);
    }

    private void SpawnFrame()
    {
        objectPooler.SpawnFromPool("Frame", starterPoint.transform.position, Quaternion.identity);
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);
    }

    public void IncreaseSpeed()
    {
        speed += 0.01f;
        Debug.Log("Speed increased");
    }
}
