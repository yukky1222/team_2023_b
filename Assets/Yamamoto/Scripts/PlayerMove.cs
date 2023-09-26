using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector3 pos;

    Vector3 Default;

    
    private bool STOP;
    Rigidbody rb;
  float jumpForce = 20.0f;
  public bool isJumping = false;
    
    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
        Default = this.transform.position;
       
    this.rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
{
  if (collision.gameObject.CompareTag("Enemy"))
  {
    STOP = true;
    
     Invoke("PLAYERSTOP",1f);
  }
   if(collision.gameObject.CompareTag("Floor"))
    {
        isJumping = false;
       
    }
}
    void FixedUpdate()
    {
        
        if(isJumping == true){
            pos.y = this.transform.position.y;
        }
         if (STOP) {
        return;
         }

        if (Input.GetKey(KeyCode.W))
        {
            pos.x += 0.15f;
             this.transform.position = pos;
    
           
        }
        else if (Input.GetKey(KeyCode.S))
        {
            pos.x -= 0.15f;
            this.transform.position = pos;
        
        }
       
    }
    void PLAYERSTOP()
    {
        pos.x = this.transform.position.x;
        //地面の標高
        pos.y = Default.y;
        STOP = false;
    }
    

  void Update()
  {
    //ジャンプする
    if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
    {
        this.rb.AddForce(transform.up * this.jumpForce, ForceMode.VelocityChange);
        isJumping = true;
       
    }
  }
}
