using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerButtonsSettings : MonoBehaviour
{
    [SerializeField]private GameObject menu;
    [SerializeField]private List<Image> listButtons;
    [SerializeField]private GameObject settings;
    [SerializeField]private GameObject panelAudio;
    [SerializeField]private GameObject panelVideo;
    [SerializeField]private GameObject panelGame;
    [SerializeField]private GameObject panelControls;
    public void Return(){
        menu.SetActive(true);
        gameObject.SetActive(false);
        ClearButtonsSprites();
    }
    public void ReturnSettings(){
        settings.SetActive(true);
        if(panelAudio.activeSelf){
            panelAudio.SetActive(false);
        }else if(panelVideo.activeSelf){
            panelVideo.SetActive(false);
        }else if(panelGame.activeSelf){
            panelGame.SetActive(false);
        }else if(panelControls.activeSelf){
            panelControls.SetActive(false);
        }        
        ClearButtonsSprites();
    }
    
    public void Audio(){
        settings.SetActive(false);
        panelAudio.SetActive(true);
        ClearButtonsSprites();
    }
    public void Video(){
        settings.SetActive(false);
        panelVideo.SetActive(true);
        ClearButtonsSprites();
    }
    public void Game(){
        settings.SetActive(false);
        panelGame.SetActive(true);
        ClearButtonsSprites();
    }
    public void Controls(){
        settings.SetActive(false);
        panelControls.SetActive(true);
        ClearButtonsSprites();
    }
    
    private void ClearButtonsSprites(){
        foreach(Image button in listButtons){
            button.enabled=false;
        }
    }
}
