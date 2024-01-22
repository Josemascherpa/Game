using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MovementCharacter : MonoBehaviour
{
    public float velocity=6;
    void Update()
    {       
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 direccion = new Vector3(movimientoHorizontal, movimientoVertical, 0).normalized;
        transform.position += direccion * velocity * Time.deltaTime;
    }
}
