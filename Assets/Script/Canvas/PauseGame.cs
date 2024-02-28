using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject panelPause;
    [SerializeField] private AssetReference menuScene;
    [SerializeField] private AssetReference sceneLvl;
    bool pause = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!pause)
            {
                Time.timeScale=0;
                pause = true;
                panelPause.SetActive(true);
            }else{
                Time.timeScale=1;
                pause=false;
                panelPause.SetActive(false);
            }
        }
    }

    public async void ReturnMenu(){
        Time.timeScale=1;
        await SceneManagerBehaviour.Instance.ChangeScene(menuScene); 
    }

    public void Continue(){
        pause=false;
        Time.timeScale=1;
        panelPause.SetActive(false);
    }

    public async void Retry()
    {
        Time.timeScale=1;
        await SceneManagerBehaviour.Instance.ChangeScene(sceneLvl);
    }
}
