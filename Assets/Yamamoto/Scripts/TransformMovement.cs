using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMovement : MonoBehaviour
{
      float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            float horizontalInput = Input.GetAxis("Horizontal");

        // transformを使って座標を変更する
        Vector3 newPosition = transform.position + new Vector3(horizontalInput, 0f, 0f) * speed * Time.deltaTime;
        transform.position = newPosition;
    
    }
}
