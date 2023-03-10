using UnityEngine;
using UnityEngine.UI;

public class TapToStartButton : MonoBehaviour
{
    private Button tapToStartButton;

    public void StartGame()
    {
        Time.timeScale = 1;
        Destroy(this.gameObject);
        GameEventManager.instance.GameStart();
    }
}
