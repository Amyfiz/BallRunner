using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private bool isGoingUp = false;
    public Rigidbody2D rigidbody;
    public float flyForce = 10f;
    
    private void Start()
    {
        
    }

    void FixedUpdate()
    {
        if (isGoingUp)
        {
            rigidbody.AddForce(transform.up * flyForce * Time.fixedDeltaTime * 100f, ForceMode2D.Force);
        }
    }

    public void Up(bool _isGoingUp)
    {
        isGoingUp = _isGoingUp;
    }
}
