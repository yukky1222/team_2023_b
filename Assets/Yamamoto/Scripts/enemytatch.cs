using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemytatch : MonoBehaviour

{
    //　主人公キャラクターのダメージ処理スクリプト
    [SerializeField]
    private LifeGaugeCharacter lifeGaugeCharacter;
 
    private bool isInvincible;
    public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();}

   

   void OnCollisionEnter(Collision collision)
{
    
  if (collision.gameObject.CompareTag("Enemy"))
  {
      if (isInvincible) {
        return;
    }
        audioSource.PlayOneShot(sound1);
        lifeGaugeCharacter.Damage(1);
 
    isInvincible = true;
 
    // ここにノックバック処理

    
    Invoke("STAR",1f);
  }

}
    void STAR()
    {
        isInvincible = false;
    }
}
