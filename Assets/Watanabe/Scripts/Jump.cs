using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
   Rigidbody rigidbody;
  float jumpForce = 680.0f;
  private bool isJumping = false;

  void Start()
  {
    this.rigidbody = this.gameObject.GetComponent<Rigidbody>();
  }

  void Update()
  {
    //ジャンプする
    if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
    {
        this.rigidbody.AddForce(transform.up * this.jumpForce);
        isJumping = true;
    }
  }

  private void OnCollisionEnter(Collision collision)
  {
    //接地しているかの判定
    if(collision.gameObject.CompareTag("Floor"))
    {
        isJumping = false;
    }
  }
}
