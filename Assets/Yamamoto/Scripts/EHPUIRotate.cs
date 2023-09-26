using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EHPUIRotate : MonoBehaviour
{
     void LateUpdate() {
        //　カメラと同じ向きに設定
        transform.rotation = Camera.main.transform.rotation;
    }
}
