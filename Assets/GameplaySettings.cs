using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplaySettings : MonoBehaviour
{
    private int characterSelected=0;
    private void Awake(){ 
        DontDestroyOnLoad(this); 
    }
    public void SetCharacterSelected(int player){
        characterSelected = player;
    }

    public int GetCharacterSelected(){
        return characterSelected;
    }
}
