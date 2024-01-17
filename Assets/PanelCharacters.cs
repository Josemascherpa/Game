using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelCharacters : MonoBehaviour
{
    [SerializeField] private GameObject gameplaySettingsPrefabs;
    GameplaySettings gameplaySettingsScript;
    
    private void Start()
    {
        gameplaySettingsScript = FindFirstObjectByType<GameplaySettings>();
        if (gameplaySettingsScript == null)
        {
            GameObject instanceGameplay = Instantiate(gameplaySettingsPrefabs);
            gameplaySettingsScript = instanceGameplay.GetComponent<GameplaySettings>();
        }        
    }
    public void RandomCharacters()
    {
        gameplaySettingsScript.SetCharacterSelected(Random.Range(1, 4));
    }

    public void Amarillo()
    {
        gameplaySettingsScript.SetCharacterSelected(1);
    }

    public void Rojo()
    {
        gameplaySettingsScript.SetCharacterSelected(2);
    }
    public void Blanco()
    {
        gameplaySettingsScript.SetCharacterSelected(3);
    }
    public void Verde()
    {
        gameplaySettingsScript.SetCharacterSelected(4);        
    }

    public void ChangeSceneGame()
    {
        
        SceneManager.LoadScene("Game");
    }
}
