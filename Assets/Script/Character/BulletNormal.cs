using UnityEngine;
public class BulletNormal : MonoBehaviour
{
    public float speed = 3;

    //Collide
    Collider2D myCollider;
    Collider2D[] colliders;
    ContactFilter2D contactFilter = new ContactFilter2D();
    private OPParticlesBullet particlesBulletScript;

    private void Start()
    {
        particlesBulletScript = GameObject.FindGameObjectWithTag("OPParticlesBullet").GetComponent<OPParticlesBullet>();
        myCollider = GetComponent<Collider2D>();
        colliders = new Collider2D[1];
    }

    void Update()
    {
        CollisionBullet();
        transform.position += transform.up * speed * Time.deltaTime;
    }
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }

    private void CollisionBullet()
    {
        if (myCollider.OverlapCollider(contactFilter, colliders) > 0)
        {
            foreach (Collider2D collider in colliders)
            {
                if (collider.name.Contains("BulletEnemyExp"))
                {
                    if (particlesBulletScript != null)
                    {
                        particlesBulletScript.RequestBullet(collider.gameObject.transform.position).GetComponent<ParticleSystem>().Play();                
                        ParticleSystem.MainModule particles = particlesBulletScript.RequestBullet(collider.gameObject.transform.position).GetComponent<ParticleSystem>().main;
                        
                        
                    }
                    else
                    {
                        Debug.Log("no encontro el gameobject de particulas");
                    }
                    collider.gameObject.transform.position = new Vector2(1000, 1000);
                    collider.gameObject.SetActive(false);
                    
                }
            }
        }
    }
}



