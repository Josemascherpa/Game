using System.Collections;
using UnityEngine;

public class MovementCharacter : MonoBehaviour
{
    private float maxY = 5.8f;
    private float minY = -3.8f;
    private float maxX=8.7f;
    private float minX=-8.7f;
    public float velocity = 6;
    void Update()
    {
        InputsMovements();
        LimitsMovements();
    }
    private void InputsMovements(){
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 direccion = new Vector3(movimientoHorizontal, movimientoVertical, 0).normalized;
        transform.position += direccion * velocity * Time.deltaTime;
    }
    private void LimitsMovements()
    {
        if (transform.position.y > maxY)
        {
            transform.position = new Vector2(transform.position.x, maxY);
        }
        else if (transform.position.y < minY)
        {
            transform.position = new Vector2(transform.position.x, minY);
        }
        
        if (transform.position.x < minX)
        {
            transform.position = new Vector2(minX, transform.position.y);
        }
        else if (transform.position.x > maxX)
        {
            transform.position = new Vector2(maxX, transform.position.y);
        }
    }
}
