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
        if(styleCursor>spritesCursor.Count){
            styleCursor=1;
        }       
        switch(styleCursor){
            case 1:spriteCursor.GetComponent<Image>().sprite = spritesCursor[0];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;
            case 2:spriteCursor.GetComponent<Image>().sprite = spritesCursor[1];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;
            case 3:spriteCursor.GetComponent<Image>().sprite = spritesCursor[2];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;
            case 4:spriteCursor.GetComponent<Image>().sprite = spritesCursor[3];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;  
            case 5:spriteCursor.GetComponent<Image>().sprite = spritesCursor[4];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;
            case 6:spriteCursor.GetComponent<Image>().sprite = spritesCursor[5];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;
            case 7:spriteCursor.GetComponent<Image>().sprite = spritesCursor[6];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;
            case 8:spriteCursor.GetComponent<Image>().sprite = spritesCursor[7];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;
            case 9:spriteCursor.GetComponent<Image>().sprite = spritesCursor[8];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;
            case 10:spriteCursor.GetComponent<Image>().sprite = spritesCursor[9];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;
            case 11:spriteCursor.GetComponent<Image>().sprite = spritesCursor[10];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;
            case 12:spriteCursor.GetComponent<Image>().sprite = spritesCursor[11];textNumSpriteCursor.text = styleCursor+"/"+spritesCursor.Count;break;          

        }
    }
}
