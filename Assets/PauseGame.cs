using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject panelPause;
    [SerializeField] private AssetReference menuScene;
    bool pause = false;
    void Start()
    {

    }

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
        await SceneManagerBehaviour.Instance.ChangeScene(menuScene); 
    }
}
