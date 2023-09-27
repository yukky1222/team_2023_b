using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private bool back;
    // Start is called before the first frame update
     void Update()
    {
        if(back == false){
        transform.position += transform. TransformDirection(Vector3. forward) * 0.15f; 
    }
    if(back == true){
        transform.position += transform. TransformDirection(Vector3. forward) * -0.15f; 
    }
    }
    void OnCollisionEnter(Collision collision)
{
 if(collision.gameObject.CompareTag("Floor"))
    back = true;

}
}
