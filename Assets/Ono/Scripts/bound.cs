using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bound : MonoBehaviour
{
     [SerializeField]
    private Rigidbody rb; 

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up * 10f, ForceMode.Impulse);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
