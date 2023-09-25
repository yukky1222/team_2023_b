using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour


{
    Vector3 pos;

     [SerializeField]
    private cameraMovement cameraMovement;
    private bool STOP;
    
    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
        MeshRenderer meshRenderer = this.GetComponent<MeshRenderer>();
meshRenderer.material.color = new Color(0, 0, 0, 0.0f);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
{
  if (collision.gameObject.CompareTag("Enemy"))
  {
    STOP = true;
    cameraMovement.CAMERASTOP();
     Invoke("PLAYERSTOP",1f);
  }
}
    void FixedUpdate()
    {
         if (STOP) {
        return;
         }
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            pos.x += 0.1f;
            this.transform.position = pos;
    
           
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            pos.x -= 0.1f;
            this.transform.position = pos;
    
        
        }
        
    }
    void PLAYERSTOP()
    {
        pos.x = this.transform.position.x;
        STOP = false;
    }
}