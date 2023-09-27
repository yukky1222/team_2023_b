using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WataameMovement : MonoBehaviour
{
    Vector3 pos;
    [SerializeField]
    private float MovementVolume;
    [SerializeField]
    private int COUNT;
    private bool WATAAME;
    private int CountWataame;
    // Start is called before the first frame update
    void Start()
    {
         pos = this.transform.position;
         CountWataame = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(CountWataame == 0){
            WATAAME = true;
        }
        if(CountWataame == COUNT){
            WATAAME = false;
        }

        if(WATAAME == true){
         pos.x += MovementVolume;
             this.transform.position = pos;
             CountWataame += 1;
        }
        if(WATAAME == false){
         pos.x -= MovementVolume;
             this.transform.position = pos;
             CountWataame -= 1;
        }
    }
}
