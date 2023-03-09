using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - SpeedHolder.currentSpeed, transform.position.y, 0);
    }
}
