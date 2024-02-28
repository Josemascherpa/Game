using UnityEngine;
public class RotationAndShotEnemy : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform positionShot1;
    [SerializeField] private Transform positionShot2;
    [SerializeField] private Transform positionShot3;
    [SerializeField] private OPBulletNormal obpoolBullet;
    public float rateFire = 1;

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Character");
        InvokeRepeating("Shotting",0.5f,rateFire);
    }
    private void Update()
    {        
        Vector2 direction = player.transform.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector2.up, direction);
    }   

    private void Shotting(){
        for(int i=0;i<3;i++){
            switch(i){
                case 0:{                    
                    GameObject bullet = obpoolBullet.RequestBullet();
                    bullet.transform.position = positionShot1.transform.position;
                    bullet.transform.rotation = positionShot1.transform.rotation;
                    bullet.transform.parent=null;
                };break;
                case 1:{
                    GameObject bullet = obpoolBullet.RequestBullet();
                    bullet.transform.position = positionShot2.transform.position;
                    bullet.transform.rotation = positionShot2.transform.rotation;
                    bullet.transform.parent=null;
                };break;
                case 2:{
                    GameObject bullet = obpoolBullet.RequestBullet();
                    bullet.transform.position = positionShot3.transform.position;
                    bullet.transform.rotation = positionShot3.transform.rotation; 
                    bullet.transform.parent=null;                   
                };break;
            }
        }
    }


}
