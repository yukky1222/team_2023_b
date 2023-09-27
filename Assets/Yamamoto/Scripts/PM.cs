using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PM : MonoBehaviour
{
     Rigidbody rb;
     private bool isJumping;
     float jumpForce = 20.0f;
      void Start()
    {
    this.rb = this.gameObject.GetComponent<Rigidbody>();
    }
     void OnCollisionEnter(Collision collision)
{
 
   if(collision.gameObject.CompareTag("Floor"))
    {
        isJumping = false;
       
    }
}
   public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            const float targetVelocity = 12;
    const float power = 20;
    rb.AddForce(Vector3.right * ((targetVelocity - rb.velocity.x) * power), ForceMode.Acceleration);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            const float targetVelocity = -12;
    const float power = -20;
    rb.AddForce(Vector3.right * (-(targetVelocity - rb.velocity.x) * power), ForceMode.Acceleration);
            
        }
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
