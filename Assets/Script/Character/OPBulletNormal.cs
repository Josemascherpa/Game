using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPBulletNormal : MonoBehaviour
{
    [SerializeField]private GameObject prefabBullet;
    public int poolSize=50;
    public List<GameObject> bulletList;

    void Start()
    {
        AddBulletToList(poolSize);
    }

    private void AddBulletToList(int amount){
        for(int i=0;i<amount;i++){
            GameObject bullet = Instantiate(prefabBullet,transform);
            bullet.SetActive(false);
            bulletList.Add(bullet);
        }
    }

    public GameObject RequestBullet(){
        for(int i=0;i<bulletList.Count;i++){
            if(!bulletList[i].activeSelf){
                bulletList[i].SetActive(true);
                return bulletList[i];
            }
        }
        AddBulletToList(1);
        bulletList[bulletList.Count-1].SetActive(true);
        return bulletList[bulletList.Count-1];
    }
}
