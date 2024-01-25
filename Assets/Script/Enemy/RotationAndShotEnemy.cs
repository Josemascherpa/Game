using UnityEngine;


public class RotationAndShotEnemy : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform positionShot1;
    [SerializeField] private Transform positionShot2;
    [SerializeField] private Transform positionShot3;
    [SerializeField] private GameObject bulletEnemy;

    private void Start() {
        InvokeRepeating("Shotting",0.5f,1f);
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
                    GameObject bullet = Instantiate(bulletEnemy,positionShot1);

                };break;
                case 1:{
                    GameObject bullet = Instantiate(bulletEnemy,positionShot2);
                };break;
                case 2:{
                    GameObject bullet = Instantiate(bulletEnemy,positionShot3);
                    
                };break;
            }
        }
    }


}
