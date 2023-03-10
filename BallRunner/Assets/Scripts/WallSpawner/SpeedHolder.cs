using UnityEngine;

public class SpeedHolder: MonoBehaviour
{
    public static float currentSpeed = 0.1f;
    
    private void Start()
    {
        currentSpeed = 0.1f;
        
        InvokeRepeating("IncreaseSpeed", 1, 1);
    }

    public void IncreaseSpeed()
    {
        currentSpeed += DifficultyHolder.currentDifficulty.speedToIncrease;
        Debug.Log("Speed increased = " + currentSpeed);
    }
}
