using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    // Start is called before the first frame update
     void OnCollisionEnter(Collision collision)
{
  if (collision.gameObject.CompareTag("Enemy"))
    {
         Destroy(this.gameObject); 
    }
   
}
}
