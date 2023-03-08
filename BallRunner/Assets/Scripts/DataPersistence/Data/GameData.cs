using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class GameData
{
    public int deathCount;
    
    public GameData()
    {
        this.deathCount = 0;
    }
}