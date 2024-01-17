using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelCharacters : MonoBehaviour
{
    [SerializeField] private GameObject gameplaySettingsPrefabs;
    GameplaySettings gameplaySettingsScript;
    [SerializeField] private TextMeshProUGUI textNameSelected;
    
    private void Start()
    {
        gameplaySettingsScript = FindFirstObjectByType<GameplaySettings>();
        if (gameplaySettingsScript == null)
        {
            GameObject instanceGameplay = Instantiate(gameplaySettingsPrefabs);
            gameplaySettingsScript = instanceGameplay.GetComponent<GameplaySettings>();
        }        
        textNameSelected.text="Random";
    }
    public void RandomCharacters()
    {
        gameplaySettingsScript.SetCharacterSelected(Random.Range(1, 4));
        textNameSelected.text= "Random";
    }

    public void Amarillo()
    {
        gameplaySettingsScript.SetCharacterSelected(1);
        textNameSelected.text= "Yellow";
    }

    public void Rojo()
    {
        gameplaySettingsScript.SetCharacterSelected(2);
        textNameSelected.text= "Red";
    }
    public void Blanco()
    {
        gameplaySettingsScript.SetCharacterSelected(3);
        textNameSelected.text= "White";
    }
    public void Verde()
    {
        gameplaySettingsScript.SetCharacterSelected(4);  
        textNameSelected.text= "Green";      
    }

    public void ChangeSceneGame()
    {
        
        SceneManager.LoadScene("Game");
    }
}
