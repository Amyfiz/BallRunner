using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject objects;

    private void Start()
    {
        InvokeRepeating("DublicateBackground", 1, 1);
    }

    void DublicateBackground()
    {
        Instantiate(objects, new Vector3(9f, -7f, 0), Quaternion.identity);
    }
}
