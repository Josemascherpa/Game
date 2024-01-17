using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;
using MyGameDevTools.SceneLoading;

public class PanelCharacters : MonoBehaviour
{
    [SerializeField] private GameObject gameplaySettingsPrefabs;
    GameplaySettings gameplaySettingsScript;
    [SerializeField] private TextMeshProUGUI textNameSelected;
    [SerializeField]private AssetReference loadScene;
    [SerializeField]private AssetReference gameScene;
    
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

    public async void ChangeSceneGame()
    {                        
        LoadingFaderNacho.fadeTime = 0;
        await SceneManagerBehaviour.Instance.ChangeScene(gameScene);               
    }
}
