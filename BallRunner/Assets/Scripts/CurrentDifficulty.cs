using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentDifficulty : MonoBehaviour
{
    private static DifficultyEntity currentDifficulty;
    public float wallFrequency;
    public float speedToIncrease;

    private void Awake()
    {
        currentDifficulty = DifficultyHolder.currentDifficulty;
    }

    private void Update()
    {
        wallFrequency = currentDifficulty.wallFrequency;
        speedToIncrease = currentDifficulty.speedToIncrease;
    }
}
