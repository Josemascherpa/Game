using UnityEngine;

public class LookAtMouse : MonoBehaviour
{    
    private void Update()
    {        
        Vector2 mouseScreenPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mouseScreenPosition - (Vector2)transform.position).normalized;
        transform.up = direction;
    }
}
