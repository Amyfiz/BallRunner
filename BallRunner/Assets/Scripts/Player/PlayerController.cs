using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    private float flyForce = 10f;
    
    private void Start()
    {
        GameStart();
        Time.timeScale = 0;
    }

    public void GameStart()
    {
        GameEventManager.instance.GameStart();
        transform.position = new Vector3(3, -7, 0);
    }

    public void OnTriggerEnter2D(Collider2D wall)
    {
        if (wall.tag == "Wall")
        {
            Death();
        }
    }

    public void Death()
    {
        GameEventManager.instance.PlayerDeath();
        DataPersistenceManager.instance.SaveGame();
        Time.timeScale = 0;
    }
}
