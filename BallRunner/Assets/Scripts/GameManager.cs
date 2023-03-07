using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject frame;

    private void Start()
    {
        InvokeRepeating("DublicateObjects", 1, 1);
    }

    void DublicateObjects()
    {
        Instantiate(frame, new Vector3(27f, -7f, 0), Quaternion.identity);
    }
}
