using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
     
         
    }
    void FixedUpdate()
    {
        
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
}