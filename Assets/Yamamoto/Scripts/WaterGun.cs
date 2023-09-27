using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGun : MonoBehaviour
{
    Vector3 worldAngle;
    public Quaternion GunRotation; // GunRotationっていう箱を作った←Vector3無理っぽい
    //Quaternionで数値を指定するのは難しい。
    // Start is called before the first frame update
    void Start()
    {
        GunRotation = gameObject.transform.rotation;
        Transform myTransform = this.transform;
        worldAngle = transform.eulerAngles;
       
        //GunRotationにオブジェクトの初期回転情報を入れた。
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    void FixedUpdate()//なんかこっちのがいい
    {
         if (Input.GetMouseButton(1)) //条件￥右クリック押している間
        {
            transform.Rotate(new Vector3(0, 0, 1));//条件満たされればZ軸の回転＋１
           transform.localScale = new Vector3(1, 0.2f, 0.2f);//条件満たされればスケール（水鉄砲の大きさ）に＝オブジェクト表示
        }
        else//条件￥上記条件が偽　
        {//条件満たされれば０．１秒？後に”Reset”を実行する
          transform.localScale = Vector3.zero;//スケールを０に＝オブジェクト非表示
        }
       
    }
    
}
