
using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Particles
    [SerializeField] private GameObject particles;

    //Collide
    Collider2D myCollider;
    Collider2D[] colliders;
    ContactFilter2D contactFilter = new ContactFilter2D();

    //Lifes
    public int life = 0;

    //Events
    public delegate void ShakeCamera();
    public static event ShakeCamera shakeEvent;
    
    void Start()
    {
        myCollider = GetComponent<Collider2D>();
        colliders = new Collider2D[1];
    }
    // Update is called once per frame
    void Update()
    {
        if (myCollider.OverlapCollider(contactFilter, colliders) > 0)
        {
            foreach (Collider2D collider in colliders)
            {
                if (collider.name.Contains("Bullet"))
                {
                    life--;                    
                    if (life <= 0)
                    {
                        particles.transform.parent = null;
                        particles.GetComponent<ParticleSystem>().Play();                        
                        Destroy(this.gameObject);
                    }
                    collider.gameObject.transform.position = new Vector2(1000,1000);
                    collider.gameObject.SetActive(false);
                }
                else if (collider.name.Contains("Character"))
                {
                    particles.transform.parent = null;
                    particles.GetComponent<ParticleSystem>().Play();
                    shakeEvent.Invoke();
                    Destroy(this.gameObject);
                }
            }
            
        }
    }
}
