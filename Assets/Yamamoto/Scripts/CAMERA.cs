using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERA : MonoBehaviour
{
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos.y = this.transform.position.y;
    }
   
    // Update is called once per frame
    void Update()
    {
        pos.z = this.transform.position.z;
        pos.x = this.transform.position.x;
        transform.position = pos;
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
