using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensor : MonoBehaviour
{
    [SerializeField]
    private Ground Ground;
    private bool SensorActive;
    // Start is called before the first frame update
    void Start()
    {
        SensorActive=true;
    }
    void Update()
    {
     if (Input.GetKey(KeyCode.LeftShift)){
        SensorActive = false;
        Ground.ColiSetOff();

     }
    }
     private void OnTriggerStay(Collider collision)
    {
         if (collision.gameObject.CompareTag("Player") && SensorActive)
  {
    Ground.ColiSet();
  }// 物体がトリガーに接触している間、常に呼ばれる
    }
 
    private void OnTriggerExit(Collider collision)
    {
       Ground.ColiSetOff(); // 物体がトリガーと離れたとき、１度だけ呼ばれる
       SensorActive = true;
    }
}
