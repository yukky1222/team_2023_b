using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForBossCamera : MonoBehaviour
{
    // Start is called before the first frame update
        [SerializeField]
    //追加　XとYの上限
    float xMAXLimit;
    [SerializeField]
    //追加　XとYの上限
    float xMINILimit;
    [SerializeField]
    //追加　XとYの上限
    float yMAXLimit;
    [SerializeField]
    //追加　XとYの上限
    float yMINILimit;
    Vector3 currentPos;
    
    

    void Update()
    {


        
        //追加　現在のポジションを保持する
        currentPos = this.transform.position;
        
        //追加　Mathf.ClampでX,Yの値それぞれが最小～最大の範囲内に収める。
        //範囲を超えていたら範囲内の値を代入する
        currentPos.x = Mathf.Clamp(currentPos.x,xMINILimit, xMAXLimit);
         currentPos.y = Mathf.Clamp(currentPos.y,yMINILimit, yMAXLimit);
        
        
        //追加　positionをcurrentPosにする
        this.transform.position = currentPos;
        
    }
}
