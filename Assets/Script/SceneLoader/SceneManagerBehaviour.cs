
using Cysharp.Threading.Tasks;
using MyGameDevTools.SceneLoading;
using MyGameDevTools.SceneLoading.UniTaskSupport;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class SceneManagerBehaviour : MonoBehaviour
{    
    ISceneManager sceneManager = new SceneManagerAddressable();
    public ISceneLoaderUniTask sceneLoader;    
    [SerializeField] public AssetReference defaultLoaderScene;    

    public static SceneManagerBehaviour Instance
    {
        get
        {
            if (!_instance)
            {
                _instance = new GameObject(nameof(SceneManagerBehaviour)).AddComponent<SceneManagerBehaviour>();
                _instance.sceneLoader = new SceneLoaderUniTask(_instance.sceneManager);
                DontDestroyOnLoad(_instance.gameObject);
                _instance.hideFlags = HideFlags.HideAndDontSave;
            }
            return _instance;
        }
    }

    static SceneManagerBehaviour _instance;

    public async UniTask ChangeScene(AssetReference targetScene, AssetReference loadingScene=null)
    {
        
        ILoadSceneInfo loadingSceneInfo ;
        if (loadingScene == null)
        {
            loadingSceneInfo = new LoadSceneInfoAssetReference(defaultLoaderScene);
        }else
        {
            loadingSceneInfo = new LoadSceneInfoAssetReference(loadingScene);
        }
        
        ILoadSceneInfo targetSceneInfo = new LoadSceneInfoAssetReference(targetScene);         

        await sceneLoader.TransitionToSceneAsync(targetSceneInfo,loadingSceneInfo);
    }

    
    
}