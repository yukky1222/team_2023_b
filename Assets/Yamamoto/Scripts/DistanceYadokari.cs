using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceYadokari : MonoBehaviour
{
  [SerializeField] private GameObject target;
    [SerializeField] private GameObject player;

    [SerializeField]
    private MiniYadoMove MiniYadoMove;
     
    [SerializeField]
    
    private int maxHp;
    //　敵のHP
    [SerializeField]
    private int hp;
    //　敵の攻撃力
   
    //　HP表示用UI
    [SerializeField]
    private GameObject EHPUI;
    //　HP表示用スライダー
    private Slider hpSlider;


 
 
    void Start() {
        hp = maxHp;
        hpSlider = EHPUI.transform.Find("HPBar").GetComponent<Slider>();
        hpSlider.value = 1f;
        
    }
 
    public void SetHp(int hp) {
        this.hp = hp;
 
        //　HP表示用UIのアップデート
        UpdateHPValue();
 
        if (hp <= 0) {
            //　HP表示用UIを非表示にする
            HideStatusUI();
        }
    }
    
 
    public int GetHp() {
        return hp;
    }
 
    public int GetMaxHp() {
        return maxHp;
    }
 
    //　死んだらHPUIを非表示にする
    public void HideStatusUI() {
        EHPUI.SetActive(false);
        Destroy(this.gameObject);
        MiniYadoMove.DeathParent();
        
        
       


    }
 
    public void UpdateHPValue() {
        hpSlider.value = (float)GetHp() / (float)GetMaxHp();
    }



 
    
   

    void FixedUpdate()
    {
        /* ターゲットのポジションを取得 */
        Vector3 targetPos = target.transform.position;
 
        /* プレイヤーのポジションを取得 */
        Vector3 playerPos = player.transform.position;
 
        /* ターゲットとプレイヤーの距離を取得 */
       float dist = targetPos.magnitude;
       float disp = playerPos.magnitude;
       float dis = dist - disp;

       
 
        
        if(dis > -25)
        {
             MiniYadoMove.letsgo();
        
        }
      
        
       
    
        
        
    }
}
   
   



