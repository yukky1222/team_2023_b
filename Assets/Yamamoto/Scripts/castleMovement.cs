using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class castleMovement : MonoBehaviour
{
    [SerializeField]
   float upTime;
   [SerializeField]
   float leftTime;
   [SerializeField]
   private EShot EShot;
   float Time;
   bool once;
   Vector3 pos;

   public float span = 200f;
   private float currentTime = 0f;


void Update()
{
    Time += 1;
    currentTime += 1f;
    if(currentTime == span){
        EShot.EnemyShot();
        currentTime = 0f;
    }
   
    
    if(Time < upTime)
    {if(!once)
    {
        this.transform.position = new Vector3(80,5.8f,-19.7f); 
        pos = this.transform.position;
        once = true;
    }
    pos.y += 0.05f;
    this.transform.position = pos;
    }
    if(Time > upTime && Time < leftTime)
    {
    pos.x -= 0.05f;
    this.transform.position = pos;
    }
    if(Time > 1350 && Time < 1750)
    {
    pos.y -= 0.05f;
    this.transform.position = pos;
    }
    if(Time > 1750 && Time < 2700)
    {
    pos.x += 0.05f;
    this.transform.position = pos;
    }
    if(Time == 2700)
    {
        once = false;
        Time = 0;
    }
    
    
}


}

