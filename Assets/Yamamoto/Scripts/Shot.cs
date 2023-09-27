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
    public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
       audioSource = GetComponent<AudioSource>();
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
            audioSource.PlayOneShot(sound1);
            BulletZ = Bullet;
            Destroy(Bullet, 1.0f);
        }
        
    }   
    public void ReWater()
    {
        Reload = true;
    }
    
}
