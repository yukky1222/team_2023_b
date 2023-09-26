using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watergunReset : MonoBehaviour
{
    Vector3 worldAngle;
    // Start is called before the first frame update
    void Start()
    {
        worldAngle = transform.eulerAngles;
        worldAngle.z = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         if (Input.GetKey(KeyCode.W))
        {
            worldAngle.y = 0f;
            transform.eulerAngles = worldAngle;
        }
        else if (Input.GetKey(KeyCode.S))
        {     
          worldAngle.y = 180f;
          transform.eulerAngles = worldAngle;
        }
        else if (Input.GetMouseButton(1))
        {

        }
        else
        {
             Invoke("Reset", 0.01f);
        }
    }
    void Reset()
    {
         //z軸の回転を０にする。
        transform.eulerAngles = worldAngle;
    }
}

