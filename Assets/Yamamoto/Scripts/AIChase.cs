using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIChase : MonoBehaviour
{
    public Transform goal;
    [SerializeField] private GameObject target;
    [SerializeField] private GameObject player;
    private bool STOP;
     void Start()
    {
        
    }

     void OnCollisionEnter(Collision collision)
{
  if (collision.gameObject.CompareTag("Player"))
  {
    STOP = true;
    
    Invoke("STOPoff", 1f);
  }
}

    void Update()
    {
         Vector3 targetPos = target.transform.position;
 
        /* プレイヤーのポジションを取得 */
        Vector3 playerPos = player.transform.position;
 
        /* ターゲットとプレイヤーの距離を取得 */
       float dist = targetPos.magnitude;
       float disp = playerPos.magnitude;
       float dis = dist - disp;
        if (STOP == false){
        if(dis > -25)
        { if(dis < 0){
         transform.rotation = Quaternion.Euler(-76, 100, 0);
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;}
        }
        
        if(dis < 20)
        {
        if(dis > 0){
             transform.rotation = Quaternion.Euler(-76, 280, 0);
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        }
        }
    }
}
void STOPoff()
    {

    STOP = false;
    }
}