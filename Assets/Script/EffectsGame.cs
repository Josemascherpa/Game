using System.Collections;
using UnityEngine;

public class EffectsGame : MonoBehaviour
{
    void Start()
    {
        ManagerCollisionEnemy.shakeEvent+=ShakeCamera;
    }
    private void ShakeCamera(){
        StartCoroutine(Shake(0.07f,0.5f));
    }  

    public IEnumerator Shake(float duration,float magnitude){
        Vector3 originalPos = Camera.main.transform.position;
        float elapsedTime = 0f;
        while(elapsedTime<duration){
            float xOffset = Random.Range(-0.5f,0.5f)*magnitude;
            float yOffset = Random.Range(-0.5f,0.5f)*magnitude;
            Camera.main.transform.localPosition = new Vector3(xOffset,yOffset,originalPos.z);
            elapsedTime+=Time.deltaTime;
            yield return null;
        }
        Camera.main.transform.position = originalPos;
    }


}
