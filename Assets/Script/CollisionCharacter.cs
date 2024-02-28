using UnityEngine;

public class CollisionCharacter : MonoBehaviour
{
    Collider2D myCollider;
    Collider2D[] colliders;
    ContactFilter2D contactFilter = new ContactFilter2D();
    [SerializeField]private OPParticlesBullet particlesBulletScript;
    [SerializeField]private GameObject panelGamOver;
    
    void Start()
    {
        myCollider = GetComponent<Collider2D>();
        colliders = new Collider2D[1];
    }
    void Update()
    {
        if (myCollider.OverlapCollider(contactFilter, colliders) > 0)
        {
            foreach(Collider2D collider in colliders)
            {
                if(collider.name.Contains("BulletEnemy")){           
                    particlesBulletScript.RequestBullet(collider.gameObject.transform.position).GetComponent<ParticleSystem>().Play();
                    collider.gameObject.transform.position = new Vector2(1000,1000);
                    collider.gameObject.SetActive(false);
                    transform.GetChild(0).gameObject.SetActive(false);
                    Invoke("GameOver",0.5f);                    
                }else if(collider.name.Contains("BulletEnemyExplo")){           
                    particlesBulletScript.RequestBullet(collider.gameObject.transform.position).GetComponent<ParticleSystem>().Play();
                    collider.gameObject.transform.position = new Vector2(1000,1000);
                    collider.gameObject.SetActive(false);
                    transform.GetChild(0).gameObject.SetActive(false);
                    Invoke("GameOver",0.5f);                    
                }
            }
        }
    }

    private void GameOver(){
        
        Time.timeScale=0;
        panelGamOver.SetActive(true);
    }
}

