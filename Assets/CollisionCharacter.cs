using UnityEngine;

public class CollisionCharacter : MonoBehaviour
{
    Collider2D myCollider;
    Collider2D[] colliders;
    ContactFilter2D contactFilter = new ContactFilter2D();
    void Start()
    {
        myCollider = GetComponent<Collider2D>();
        colliders = new Collider2D[1];
    }

    void Update()
    {
        if (myCollider.OverlapCollider(contactFilter, colliders) > 0)
        {
            foreach (Collider2D collider in colliders)
            {
                if(collider.name.Contains("BulletEnemy")){
                    Destroy(collider.gameObject);
                }      
            }
        }
    }
}
