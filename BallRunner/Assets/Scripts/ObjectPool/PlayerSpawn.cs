using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject playerPrefab;
    
    public void Start()
    {
        Instantiate(playerPrefab, new Vector3(3, -7, 0), Quaternion.identity);
    }
}
