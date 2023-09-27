using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector3 pos;

    Vector3 Default;
     [SerializeField]
    //追加　XとYの上限
    float xMAXLimit;
    [SerializeField]
    //追加　XとYの上限
    float xMINILimit;
    [SerializeField]
    private float Volume;

    
    private bool STOP;
    Rigidbody rb;
  float jumpForce = 20.0f;
  public bool isJumping = false;
   public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        pos = this.transform.position;
        Default = this.transform.position;
       
    this.rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
{
 
   if(collision.gameObject.CompareTag("Floor"))
    {
        isJumping = false;
       
    }
}
    void FixedUpdate()
    {
        
         pos.x = Mathf.Clamp(pos.x,xMINILimit, xMAXLimit);
            pos.y = this.transform.position.y;
       
        

        if (Input.GetKey(KeyCode.W))
        {
            pos.x += Volume;
             this.transform.position = pos;
    
           
        }
        else if (Input.GetKey(KeyCode.S))
        {
            pos.x -= Volume;
            this.transform.position = pos;
        
        }
       
    }
   
    

  void Update()
  {
    //ジャンプする
    if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
    { audioSource.PlayOneShot(sound1);
        this.rb.AddForce(transform.up * this.jumpForce, ForceMode.VelocityChange);
        isJumping = true;
       
    }
  }
}
