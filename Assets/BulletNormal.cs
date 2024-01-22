using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletNormal : MonoBehaviour
{
    public float speed = 3;

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up*speed*Time.deltaTime;
    }
    private void OnBecameInvisible(){
        gameObject.SetActive(false);
    }
}
