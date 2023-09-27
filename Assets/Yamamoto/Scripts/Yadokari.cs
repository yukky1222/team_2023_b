using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yadokari : MonoBehaviour
{
    
    [SerializeField]
private DistanceYadokari DistanceYadokari;
 

 void OnCollisionEnter(Collision collision)
{
  if (collision.gameObject.CompareTag("Bullet"))
  {//damage
    DistanceYadokari.SetHp(DistanceYadokari.GetHp() - 1);
   
   
  }

}
}
