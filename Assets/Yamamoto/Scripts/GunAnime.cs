using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAnime : MonoBehaviour
{
     private Animator anim;  
    // Start is called before the first frame update
  void Start()
    {
        // アニメーターコンポーネント取得
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    public void Recoil()
    {
         anim.SetBool("GunReaction", true);
    }
    public void Recoiloff()
    {
         anim.SetBool("GunReaction", false);
    }
}
