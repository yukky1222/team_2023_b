using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
bool set;
	BoxCollider colliderOfGround;
	
	void Start ()
	{
		colliderOfGround = GetComponent<BoxCollider>();
        
	}
	
	void Update (){
        if(set){
            colliderOfGround.enabled = true;
        }
		 if(!set){
            colliderOfGround.enabled = false;
        }
	}
	public void ColiSet()
    {
        set=true;
    }
    public void ColiSetOff()
    {
        set = false;
    }

	
}