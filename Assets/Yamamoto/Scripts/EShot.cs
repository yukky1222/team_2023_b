using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EShot : MonoBehaviour
{
     public GameObject bullet;
   public GameObject BulletZ;
    public float bulletSpeed;
    // Start is called before the first frame update
    
    // Update is called once per frame
   public void EnemyShot()
    {
        
           
            GameObject Bullet = (GameObject)Instantiate(bullet, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
            BulletZ = Bullet;
            Destroy(Bullet, 6.0f);
        
        
    }   
    public void HitBullet()
    {
            Destroy(BulletZ); 
        }
   
}

