using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeHitodeMove : MonoBehaviour
{
     Vector3 pos;
    [SerializeField]
    private float MovementVolume;
    [SerializeField]
    private int COUNT;
    private bool Hitode;
    private int CountHitode;
    // Start is called before the first frame update
    void Start()
    {
         pos = this.transform.position;
         CountHitode = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(CountHitode == 0){
            Hitode = true;
        }
        if(CountHitode == COUNT){
           Hitode = false;
        }

        if(Hitode == true){
         pos.z += MovementVolume;
             this.transform.position = pos;
             CountHitode += 1;
        }
        if(Hitode == false){
         pos.z -= MovementVolume;
             this.transform.position = pos;
             CountHitode -= 1;
        }
    }
}

