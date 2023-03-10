using System;
using UnityEngine;

public class ButtonUp : MonoBehaviour
{
    private bool isGoingUp = false;
    private PlayerController playerController;

    private void Start()
    {
        playerController = FindObjectOfType<PlayerController>();
    }

    private void Update()
    {
        if (isGoingUp)
        {
            playerController.rigidbody.AddForce(transform.up * Time.fixedDeltaTime * 150f, ForceMode2D.Force);
        }
    }
    
    public void Up(bool _isGoingUp)
    {
        isGoingUp = _isGoingUp;
    }
}
