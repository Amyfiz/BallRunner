using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float speed;
    public int secondsToSpeedUp;

    private void Start()
    {
        speed = 0.1f;
        InvokeRepeating("IncreaseSpeed", secondsToSpeedUp, secondsToSpeedUp);
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
