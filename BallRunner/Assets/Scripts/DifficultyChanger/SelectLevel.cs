using UnityEngine;

public class SelectLevel : MonoBehaviour
{
    public DifficultyEntity easyLevel;
    public DifficultyEntity mediumLevel;
    public DifficultyEntity hardLevel;
    
    private void Start()
    {
        if (DifficultyHolder.currentDifficulty == null)
        {
            DifficultyHolder.currentDifficulty = easyLevel;
        }
    }
    
    public void SetEasyLevel()
    {
        DifficultyHolder.currentDifficulty = easyLevel;
        Debug.Log("Easy");
    }
    
    public void SetMediumLevel()
    {
        DifficultyHolder.currentDifficulty = mediumLevel;
        Debug.Log("Medium");
    }
    
    public void SetHardLevel()
    {
        DifficultyHolder.currentDifficulty = hardLevel;
        Debug.Log("Hard");
    }
}
