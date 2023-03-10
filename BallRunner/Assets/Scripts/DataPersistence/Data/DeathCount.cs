using UnityEngine;
using TMPro;

public class DeathCount : MonoBehaviour, IDataPersistence
{
    private int deathCount = 0;

    public TextMeshProUGUI deathCountTextCanvas;
    public TextMeshProUGUI deathCountTextGameOver;

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
        GameEventManager.instance.onPlayerDeath += OnPlayerDeath;
    }

    private void OnDestroy() 
    {
        GameEventManager.instance.onPlayerDeath -= OnPlayerDeath;
    }

    private void OnPlayerDeath() 
    {
        deathCount++;
    }

    private void Update() 
    {
        deathCountTextCanvas.text = "" + deathCount;
        deathCountTextGameOver.text = "" + deathCount;
    }
}
