using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
