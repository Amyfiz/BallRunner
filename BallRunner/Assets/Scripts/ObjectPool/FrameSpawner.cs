using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameSpawner : MonoBehaviour
{
    //public GameObject framePrefab;
    private ObjectPooler objectPooler;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
        //Instantiate(framePrefab, new Vector3(9f, -7, 0), Quaternion.identity);
        //objectPooler.SpawnFromPool("Frame", new Vector3(9f, -7, 0), Quaternion.identity);

        InvokeRepeating("SpawnFrame", 0, 1);
    }

    private void SpawnFrame()
    {
        objectPooler.SpawnFromPool("Frame", new Vector3(9f, -7, 0), Quaternion.identity);
        //Instantiate(framePrefab, new Vector3(9f, -7, 0), Quaternion.identity);
    }
}
