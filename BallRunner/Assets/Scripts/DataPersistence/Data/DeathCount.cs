using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathCount : MonoBehaviour, IDataPersistence
{
    private int deathCount = 0;

    private TextMeshProUGUI deathCountText;

    private void Awake() 
    {
        deathCountText = this.GetComponent<TextMeshProUGUI>();
    }
    
    public void LoadData(GameData data)
    {
        this.deathCount = data.deathCount;
    }

    public void SaveData(ref GameData data)
    {
        data.deathCount = this.deathCount;
    }

    private void Start() 
    {
        // subscribe to events
        GameEventManager.instance.onPlayerDeath += OnPlayerDeath;
    }

    private void OnDestroy() 
    {
        // unsubscribe from events
        GameEventManager.instance.onPlayerDeath -= OnPlayerDeath;
    }

    private void OnPlayerDeath() 
    {
        deathCount++;
        //Debug.Log("Deaths: " + deathCount);
    }

    private void Update() 
    {
        deathCountText.text = "Deaths: " + deathCount;
    }
}
