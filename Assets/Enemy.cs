
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]private GameObject particles;
    Collider2D myCollider;    
    Collider2D[] colliders;
    ContactFilter2D contactFilter = new ContactFilter2D();
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
        if(myCollider.OverlapCollider(contactFilter,colliders)>0){
            foreach (Collider2D collider in colliders)
            {                
                if(collider.name.Contains("Bullet")){
                    particles.transform.parent = null;
                    particles.GetComponent<ParticleSystem>().Play();
                    Destroy(this.gameObject);
                }else if(collider.name.Contains("Character")){
                    particles.transform.parent = null;
                    particles.GetComponent<ParticleSystem>().Play();
                    shakeEvent.Invoke();
                    Destroy(this.gameObject);                    
                    
                }
            }
        }        
    }


    
}
