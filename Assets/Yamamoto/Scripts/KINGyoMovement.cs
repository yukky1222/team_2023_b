using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KINGyoMovement : MonoBehaviour
{
   [SerializeField]
   float speed;
   [SerializeField]
   float ChaseTime;
   [SerializeField]
   private EShot EShot;
   float Time;
   bool once;
   Vector3 pos;

void Update()
{
     Time += 1;
    if(Time < ChaseTime){
       
 transform.position += transform. TransformDirection(Vector3. forward) * speed; 
 
    }
    if(Time == 3200|Time == 3400|Time == 3600|Time == 3800|Time == 2200|Time == 2400|Time == 2600|Time == 2800)
    {
        EShot.EnemyShot();
    }
    if(Time == ChaseTime)
    {
        once = false;
    }
    if(Time > ChaseTime && Time < 3000)
    {if(!once)
    {
        this.transform.position = new Vector3(95,27,-20.7f); 
        pos = this.transform.position;
        once = true;
    }
    pos.x -= 0.08f;
    pos.y -= 0.025f;
    this.transform.position = pos;
    }
    if(Time == 3000)
    {
        once = false;
    }
    if(Time > 3000 && Time < 4000)
    {if(!once)
    {
        this.transform.position = new Vector3(20,27,-20.7f); 
        pos = this.transform.position;
        once = true;
    }
    pos.x += 0.08f;
    pos.y -= 0.025f;
    this.transform.position = pos;
    }
    if (Time == 4000)
    {
        Time = 0;
    }




}
}