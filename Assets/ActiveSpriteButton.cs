using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ActiveSpriteButton : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler
{
    
    public void OnPointerEnter(PointerEventData eventData){
        GetComponent<Image>().enabled=true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponent<Image>().enabled=false;
    }
}
