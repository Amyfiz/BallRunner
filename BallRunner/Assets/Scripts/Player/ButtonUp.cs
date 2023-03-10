using UnityEngine;

public class ButtonUp : MonoBehaviour
{
    private bool isGoingUp = false;

    private void Update()
    {
        if (isGoingUp)
        {
            FindObjectOfType<PlayerController>().rigidbody
                .AddForce(transform.up * Time.fixedDeltaTime * 150f, ForceMode2D.Force);
        }
    }
    
    public void Up(bool _isGoingUp)
    {
        isGoingUp = _isGoingUp;
    }
}
