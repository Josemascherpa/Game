using UnityEngine;
using TMPro;
using System.Collections.Generic;
using UnityEngine.UI;

public class PanelVideo : MonoBehaviour
{
    [SerializeField]private GameObject spriteCursor;
    [SerializeField]private TextMeshProUGUI textNumSpriteCursor;
    [SerializeField]private List<Sprite> spritesCursor;
    private int styleCursor=1;

    private void Start() {
        textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;
    }

    public void ChangeSpriteCursor(){
        styleCursor++;
        if(styleCursor>4){
            styleCursor=1;
        }       
        switch(styleCursor){
            case 1:spriteCursor.GetComponent<Image>().sprite = spritesCursor[0];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;
            case 2:spriteCursor.GetComponent<Image>().sprite = spritesCursor[1];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;
            case 3:spriteCursor.GetComponent<Image>().sprite = spritesCursor[2];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;
            case 4:spriteCursor.GetComponent<Image>().sprite = spritesCursor[3];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;            
        }
    }
}
