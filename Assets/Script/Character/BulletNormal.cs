using UnityEngine;
public class BulletNormal : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    public float speed = 3;

    // Update is called once per frame
    private void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Finish");   
    }
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;        
    }
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
