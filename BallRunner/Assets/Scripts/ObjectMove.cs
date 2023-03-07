using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        speed = 0.1f;
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);
        
        //if (transform.position.x <= )
    }
}
