using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    public float speed = 7;
    void Start()
    {
        transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;        
    }
    private void OnBecameInvisible() {
        gameObject.SetActive(false);
    }
}
