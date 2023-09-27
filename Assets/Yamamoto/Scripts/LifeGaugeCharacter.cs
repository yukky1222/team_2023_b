using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeGaugeCharacter : MonoBehaviour
{
    //　HP
    [SerializeField]
    private int hp;
    //　LifeGaugeスクリプト
    [SerializeField]
    private LifeGauge lifeGauge;
    
    public AudioClip sound1;
    AudioSource audioSource;
    


    // Start is called before the first frame update
    
    
    // Start is called before the first frame update
    
        
    
 
    // Start is called before the first frame update
    void Start()
    {
        //　体力の初期化
        hp = 5;
        //　体力ゲージに反映
        lifeGauge.SetLifeGauge(hp);
        audioSource = GetComponent<AudioSource>();
   
       
    }
 
    // Update is called once per frame
    void Update()
    {
        if(hp == 0)
        {//プレイヤーのライフがゼロになったときに行う処理。
        
         audioSource.Stop();
          
        }
    }
 
    //　ダメージ処理メソッド（全削除＆HP分作成）
    public void Damage(int damage) {
       
        hp -= damage;
        //　0より下の数値にならないようにする
        hp = Mathf.Max(0, hp);
 
        if (hp >= 0) {
            lifeGauge.SetLifeGauge(hp);
        }
    }
    //　ダメージ処理メソッド（ダメージ数分だけアイコンを削除）
    public void Damage2(int damage) {
        hp -= damage;
        if(hp < 0) {
            //　ダメージ調整
            damage = Mathf.Abs(hp + damage);
            hp = 0;
        }
        if(damage > 0) {
            lifeGauge.SetLifeGauge2(damage);
        }
    }
}
