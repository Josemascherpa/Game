
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;


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
        textNameSelected.color = Color.yellow;
    }

    public void Rojo()
    {
        gameplaySettingsScript.SetCharacterSelected(2);
        textNameSelected.text= "Red";
        textNameSelected.color = Color.red;
    }
    public void Blanco()
    {
        gameplaySettingsScript.SetCharacterSelected(3);
        textNameSelected.text= "White";
        textNameSelected.color = Color.white;
    }
    public void Verde()
    {
        gameplaySettingsScript.SetCharacterSelected(4);  
        textNameSelected.text= "Green";     
        textNameSelected.color = Color.green; 
    }

    public async void ChangeSceneGame()
    {                        
        LoadingFaderNacho.fadeTime = 0;
        await SceneManagerBehaviour.Instance.ChangeScene(gameScene);               
    }
}
