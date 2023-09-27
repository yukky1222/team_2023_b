using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceYadokari : MonoBehaviour
{
  [SerializeField] private GameObject target;
    [SerializeField] private GameObject player;

    [SerializeField]
    private MiniYadoMove MiniYadoMove;

  
   
  Vector3 pos;
  private bool STOP;
  private bool await;

 
    
   
    void Start()
    {
         pos = this.transform.position;
    }

     void OnCollisionEnter(Collision collision)
{
  if (collision.gameObject.CompareTag("Player"))
  {
    STOP = true;
     var rigidbody = GetComponent<Rigidbody>();
rigidbody.AddForce(-transform.right * 10f, ForceMode.VelocityChange);
    
    Invoke("STOPoff", 1f);
  }
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

       
 
        if (STOP == false){
        if(dis > -25)
        {
             MiniYadoMove.letsgo();
        if(dis < 0)
        {
           Invoke("hidari",0.8f);
           
            
        }
        }
        if(dis < 20)
        {
        if(dis > 0)
        {
            Invoke("migi",0.8f);
           
            
        }
      
        }
   
        this.transform.position = pos;
       
    
        }
        
    }
    void STOPoff()
    {
    pos.x = this.transform.position.x;
    STOP = false;
    }
   
    void hidari()
    {
       transform.rotation = Quaternion.Euler(-76, 100, 0);
        pos.x -= 0.08f;
       
    }
    void migi()
    {
       transform.rotation = Quaternion.Euler(-76,280, 0);
        pos.x += 0.08f;
    }
}


