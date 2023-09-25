using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemytatch : MonoBehaviour

{
    //　主人公キャラクターのダメージ処理スクリプト
    [SerializeField]
    private LifeGaugeCharacter lifeGaugeCharacter;
 
    private bool isInvincible;

    
   void OnCollisionEnter(Collision collision)
{
  if (collision.gameObject.CompareTag("Enemy"))
  {
      if (isInvincible) {
        return;
    }
        Debug.Log("ダメージ");
        lifeGaugeCharacter.Damage(1);
 
    isInvincible = true;
 
    // ここにノックバック処理
 var rigidbody = GetComponent<Rigidbody>();
rigidbody.AddForce(-transform.right * 10f, ForceMode.VelocityChange);
    
    Invoke("STAR",1f);
  }

}
    void STAR()
    {
        isInvincible = false;
    }
}
