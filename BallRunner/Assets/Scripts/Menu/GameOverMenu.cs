using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public GameObject gameOverMenu;
    
    public void Start()
    {
        GameEventManager.instance.onGameStart += HideGameOverMenu;
        GameEventManager.instance.onPlayerDeath += ShowGameOverMenu;
    }

    public void OnDestroy()
    {
        GameEventManager.instance.onGameStart -= HideGameOverMenu;
        GameEventManager.instance.onPlayerDeath -= ShowGameOverMenu;
    }

    public void ShowGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }
    
    public void HideGameOverMenu()
    {
        gameOverMenu.SetActive(false);
    }

    public void StartOver()
    {
        SceneManager.LoadScene(1);
    }
    
    public void Quit()
        {
            Application.Quit();
            Debug.Log("Quit");
        }
}
