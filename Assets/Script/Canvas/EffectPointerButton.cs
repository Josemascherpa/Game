using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG;
using DG.Tweening;
using UnityEngine.UI;

public class EffectPointerButton : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{    
    private GameObject parent;

    private void Start() {
        parent = transform.parent.gameObject;//obtengo el padre para desactivarle el layout horizontal y poder hacer la tween
    }
    public void OnPointerEnter(PointerEventData eventData){
        //tweeen que suba
        parent.GetComponent<HorizontalLayoutGroup>().enabled=false;
        transform.DOMoveY(transform.position.y+10,0);

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        parent.GetComponent<HorizontalLayoutGroup>().enabled=true;
        //Tween que bajes
    }

}
