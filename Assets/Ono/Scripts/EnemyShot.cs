using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject shellPrefab;
    public AudioClip sound;
    private int count;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnWillRenderObject()

{

#if UNITY_EDITOR

	if(Camera.current.name != "SceneCamera"  && Camera.current.name != "Main Camera")

#endif
    {
          count += 1;
 
        if(count % 300 == 0)
        {
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();
 
            shellRb.AddForce(transform.forward * 500);
 
            AudioSource.PlayClipAtPoint(sound, transform.position);
 
            Destroy(shell, 5.0f);
        }
    }
}
}