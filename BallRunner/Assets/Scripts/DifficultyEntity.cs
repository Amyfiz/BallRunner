using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Difficulty", menuName = "Difficulty", order = 1)]
public class DifficultyEntity : ScriptableObject
{
    public float wallFrequency;
    public float speedToIncrease;
}
