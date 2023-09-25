using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    Vector3 pos;
    private bool STOP;
    
    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    public void CAMERASTOP()
{
    STOP = true;
     Invoke("CAMERASTART",1f);
  }

    void FixedUpdate()
    {
         if (STOP) {
        return;
         }
        
        if (Input.GetKey(KeyCode.W))
        {
           
            pos.x += 0.1f;
            this.transform.position = pos;
    
           
        }
        else if (Input.GetKey(KeyCode.S))
        {
            
            pos.x -= 0.1f;
            this.transform.position = pos;
    
        
        }
        
    }
    void CAMERASTART()
    {
        
        pos.x -=5.15f;
        STOP = false;
    }
}