using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
 [SerializeField]
private EnemyStatus EnemyStatus;
 

 void OnCollisionEnter(Collision collision)
{
  if (collision.gameObject.CompareTag("Bullet"))
  {//damage
    EnemyStatus.SetHp(EnemyStatus.GetHp() - 1);
   
   
  }

}
}
