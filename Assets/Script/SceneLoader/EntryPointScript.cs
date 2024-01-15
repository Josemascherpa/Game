using MyGameDevTools.SceneLoading;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class EntryPointScript : MonoBehaviour
{
    [SerializeField]AssetReference firstScene;
    [SerializeField]AssetReference loadScene;    

    private async void Start()
    {                   
        
        SceneManagerBehaviour.Instance.defaultLoaderScene = loadScene;
        
        await SceneManagerBehaviour.Instance.ChangeScene(firstScene);

        UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(this.gameObject.scene);
    }

    
}