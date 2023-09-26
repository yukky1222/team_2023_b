using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStatus : MonoBehaviour
{
    // Start is called before the first frame update
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

    }
 
    public void UpdateHPValue() {
        hpSlider.value = (float)GetHp() / (float)GetMaxHp();
    }
 
}
