using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    private ObjectPooler objectPooler;
    public float vectorX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;

    void Start()
    {
        objectPooler = ObjectPooler.Instance;
        
        InvokeRepeating("Spawn", 0, timeBetweenSpawn);
    }

    public void Spawn()
    {
        float randomY = Random.Range(minY, maxY);
        
        objectPooler.SpawnFromPool("Wall", new Vector3(vectorX, randomY, 0), Quaternion.identity);
    }
}
