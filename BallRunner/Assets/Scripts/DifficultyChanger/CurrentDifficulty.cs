using UnityEngine;

/// <summary>
/// Checking what difficulty are we on. Not being used anywhere.
/// </summary>

public class CurrentDifficulty : MonoBehaviour
{
    public float wallFrequency;
    public float speedToIncrease;

    private void Update()
    {
        wallFrequency = DifficultyHolder.currentDifficulty.wallFrequency;
        speedToIncrease = DifficultyHolder.currentDifficulty.speedToIncrease;
    }
}
