using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{
    private bool stopwatchActivate = false;
    private float currentTime;
    public TextMeshProUGUI currentTimeText;
    
    public void Start()
    {
        currentTime = 0;
    }

    private void Update()
    {
        if (stopwatchActivate)
        {
            currentTime += Time.deltaTime;
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }

    public void StartStopwatch()
    {
        stopwatchActivate = true;
    }

    public void StopStopwatch()
    {
        stopwatchActivate = false;
    }
}
