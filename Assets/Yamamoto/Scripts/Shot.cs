using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
   
   public GameObject bullet;
   public GameObject BulletZ;
    public float bulletSpeed;

     [SerializeField]
    private WaterReload WaterReload;
    public bool Reload;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
   public void Update()
    {
        if (Reload == true && Input.GetMouseButtonUp(1))
        {
            Reload = false;
            WaterReload.ReloadReset();
            GameObject Bullet = (GameObject)Instantiate(bullet, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
            Rigidbody bulletRb = Bullet.GetComponent<Rigidbody>();
            bulletRb.AddForce(transform.forward * -bulletSpeed);
            BulletZ = Bullet;
            Destroy(Bullet, 3.0f);
        }
        
    }   
    public void ReWater()
    {
        Reload = true;
    }
    public void HitBullet()
    {
            Destroy(BulletZ); 
        }
   
}
