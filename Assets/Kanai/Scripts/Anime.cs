using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anime : MonoBehaviour
{
    //Animatorをanimという変数で定義する
    private Animator anim; 
   
    void Start()
    {
        //変数animに、Animatorコンポーネントを設定する
        anim = gameObject.GetComponent<Animator>();
    }

    //===== 主処理 =====
    void Update()
    {
        //もし、Wキーが押されたらなら
        if (Input.GetKey(KeyCode.W))
        {
            //Bool型のパラメーターであるPlayerRunをTrueにする
            anim.SetBool("PlayerRun", true);
        }
         //もし、Sキーが押されたらなら
        else if (Input.GetKey(KeyCode.S))
         {
            //Bool型のパラメーターであるPlayerRunをTrueにする
            anim.SetBool("PlayerRun", true);
        }
        else
        {
             //Bool型のパラメーターであるPlayerRunをFalseにする
            anim.SetBool("PlayerRun", false);
        }

        //もし、Spaceキーが押されたなら
        if(Input.GetKey(KeyCode.Space))
        {
            //Bool型のパラメーターであるPlayerJumpをTrueにする
             anim.SetBool("PlayerJump", true);
        }
        else
        {
             //Bool型のパラメーターであるPlayerJumpをFalseにする
            anim.SetBool("PlayerJump", false);
        }
    }
}