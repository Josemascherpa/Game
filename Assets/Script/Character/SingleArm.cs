using UnityEngine;

public class SingleArm : MonoBehaviour
{
    [SerializeField]private GameObject prefabBullet;
    [SerializeField]private OPBulletNormal opBullet;
    public Transform respawnBullet;
    public float rateFire=0.5f;
    private float timeShot=0;
    // Update is called once per frame
    void Update()
    {
        timeShot+=Time.deltaTime;   
        if(Input.GetMouseButton(0) && timeShot>rateFire){       
            GameObject bullet = opBullet.RequestBullet();
            bullet.transform.position = respawnBullet.position;
            bullet.transform.rotation = respawnBullet.rotation;
            bullet.transform.parent=null;
            timeShot=0;
        }
    }
}
