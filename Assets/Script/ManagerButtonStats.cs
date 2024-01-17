using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerButtonStats : MonoBehaviour
{
    [SerializeField]private GameObject menu;
    [SerializeField]private Image buttonReturn;
    public void Return(){
        menu.SetActive(true);
        gameObject.SetActive(false);
        ClearButtonsSprites();
    }
    private void ClearButtonsSprites(){
        buttonReturn.enabled=false;
    }
}
