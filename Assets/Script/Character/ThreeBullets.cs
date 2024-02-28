using UnityEngine;

public class ThreeBullets : MonoBehaviour
{
    [SerializeField] private GameObject prefabBullet;
    [SerializeField] private OPBulletNormal opBullet;
    public Transform respawnBulletCenter;
    public Transform respawnBulletLeft;
    public Transform respawnBulletRight;
    public float rateFire = 0.5f;
    private float timeShot = 0;
    // Update is called once per frame
    void Update()
    {
        timeShot += Time.deltaTime;
        if (Input.GetMouseButton(0) && timeShot > rateFire)
        {
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            GameObject bullet = opBullet.RequestBullet();
                            bullet.transform.position = respawnBulletLeft.position;
                            bullet.transform.rotation = respawnBulletLeft.rotation;
                            bullet.transform.parent = null;                         

                        }
                        break;
                    case 1:
                        {
                            GameObject bullet = opBullet.RequestBullet();
                            bullet.transform.position = respawnBulletCenter.position;
                            bullet.transform.rotation = respawnBulletCenter.rotation;
                            bullet.transform.parent = null;
                            
                        }
                        break;
                    case 2:
                        {
                            GameObject bullet = opBullet.RequestBullet();
                            bullet.transform.position = respawnBulletRight.position;
                            bullet.transform.rotation = respawnBulletRight.rotation;
                            bullet.transform.parent = null;
                            
                        }
                        break;
                    default: break;
                }
            }
            timeShot = 0;
        }
    }
}
