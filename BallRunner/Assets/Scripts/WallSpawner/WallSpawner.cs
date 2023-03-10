using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    private ObjectPooler objectPooler;
    public float vectorX;
    public float maxY;
    public float minY;

    private string[] walls = { "ThreeBlockWall", "CornerWall", "PointWall", "TWall"};
    
    void Start()
    {
        objectPooler = ObjectPooler.Instance;
        InvokeRepeating("Spawn", 0, DifficultyHolder.currentDifficulty.wallFrequency);
        Debug.Log("wall spawned");
    }

    public void Spawn()
    {
        float randomY = Random.Range(minY, maxY);
        
        System.Random randomWall = new System.Random();
        int wall = randomWall.Next(walls.Length);
        
        objectPooler.SpawnFromPool(walls[wall], new Vector3(vectorX, randomY, 0), Quaternion.identity);
    }
}
