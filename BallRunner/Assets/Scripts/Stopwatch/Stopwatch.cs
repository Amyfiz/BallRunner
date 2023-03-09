using System;
using TMPro;
using UnityEngine;

public class Stopwatch : MonoBehaviour
{
    private bool stopwatchActivate = false;
    private float currentTime;
    public TextMeshProUGUI currentTimeTextCanvas;
    public TextMeshProUGUI currentTimeTextGameOver;
    
    public void Start()
    {
        currentTime = 0;
        GameEventManager.instance.onGameStart += StartStopwatch;
        GameEventManager.instance.onPlayerDeath += StopStopwatch;
    }

    private void OnDestroy() 
    {
        GameEventManager.instance.onPlayerDeath -= StartStopwatch;
        GameEventManager.instance.onPlayerDeath -= StopStopwatch;
    }

    private void Update()
    {
        if (stopwatchActivate)
        {
            currentTime += Time.deltaTime;
        }

        TimeSpan time = TimeSpan.FromSeconds(currentTime);

        currentTimeTextCanvas.text = time.Minutes + ":" + time.Seconds;
        currentTimeTextGameOver.text = time.Minutes + ":" + time.Seconds;
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
