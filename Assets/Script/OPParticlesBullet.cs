using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPParticlesBullet : MonoBehaviour
{
    [SerializeField] private GameObject prefabParticles;
    public int poolSize = 50;
    public List<GameObject> bulletList;
    [SerializeField]private Color explosiveBulletColor;

    void Start()
    {
        AddBulletToList(poolSize);
    }

    private void AddBulletToList(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            GameObject bullet = Instantiate(prefabParticles, transform);
            bullet.SetActive(false);
            bulletList.Add(bullet);
        }
    }

    public GameObject RequestBullet(Vector2 position)
    {
        for (int i = 0; i < bulletList.Count; i++)
        {
            if (!bulletList[i].activeSelf)
            {
                bulletList[i].SetActive(true);
                bulletList[i].transform.parent = null;
                bulletList[i].transform.position = position;                
                return bulletList[i];
            }
        }
        AddBulletToList(1);
        bulletList[bulletList.Count - 1].SetActive(true);
        bulletList[bulletList.Count - 1].transform.position = position;        
        bulletList[bulletList.Count - 1].transform.parent = null;
        return bulletList[bulletList.Count - 1];
    }
}
