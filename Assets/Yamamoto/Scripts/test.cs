using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    Vector3 GunS;
    // Start is called before the first frame update
    void Start()
    {
        GunS = this.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      void FixedUpdate()
    {
         if (Input.GetMouseButton(1))
        {
            transform.localScale = new Vector3(1, 0.2f, 0.2f);
         
        }
        else
        {
             transform.localScale = Vector3.zero;
        }
    }
}
