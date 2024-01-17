using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialGameplay : MonoBehaviour
{
    [SerializeField]private GameObject character;
    private void Start() {        
        switch(FindFirstObjectByType<GameplaySettings>().GetCharacterSelected()){
            case 1:character.GetComponent<SpriteRenderer>().color = Color.yellow;break;
            case 2:character.GetComponent<SpriteRenderer>().color = Color.red;break;
            case 3:character.GetComponent<SpriteRenderer>().color = Color.white;break;
            case 4:character.GetComponent<SpriteRenderer>().color = Color.green;break;
        }
    }
}
