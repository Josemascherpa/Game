using UnityEngine;


public class FollowMouse : MonoBehaviour
{
    public Canvas parentCanvas;
    public float padding = 50f; // Ajusta este valor según el tamaño del padding que desees     
    public void Update()
    {
        Vector2 movePos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentCanvas.GetComponent<RectTransform>(),Input.mousePosition, parentCanvas.worldCamera,out movePos);
        
        float maxX = (parentCanvas.GetComponent<RectTransform>()).rect.width / 2 - padding;
        float maxY = (parentCanvas.GetComponent<RectTransform>()).rect.height / 2 - padding;

        movePos.x = Mathf.Clamp(movePos.x, -maxX, maxX);
        movePos.y = Mathf.Clamp(movePos.y, -maxY, maxY);

        transform.position = parentCanvas.transform.TransformPoint(movePos);
    }
}