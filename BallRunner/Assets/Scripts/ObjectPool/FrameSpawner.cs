using UnityEngine;

public class TopButtomWallsSpawner : MonoBehaviour
{
    private GameObject topButtomWalls;
    private ObjectPooler objectPooler;
    public GameObject starterPoint;
    private float speed;
    
    public int secondsToSpeedUp;

    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
        speed = 0.1f;
        objectPooler.SpawnFromPool("Frame", starterPoint.transform.position, Quaternion.identity);
        
        InvokeRepeating("IncreaseSpeed", secondsToSpeedUp, secondsToSpeedUp);
        InvokeRepeating("SpawnFrame", 0, 1);
    }

    private void SpawnFrame()
    {
        objectPooler.SpawnFromPool("Frame", starterPoint.transform.position, Quaternion.identity);
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x - speed, transform.position.y, 0);
    }

    public void IncreaseSpeed()
    {
        speed += 0.01f;
        Debug.Log("Speed increased");
    }
}
