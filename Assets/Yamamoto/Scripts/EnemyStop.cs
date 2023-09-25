using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStop : MonoBehaviour
{
    [SerializeField]
    private Distance Distance;

    public bool STOP;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
{
  if (collision.gameObject.CompareTag("Player"))
  {
    Debug.Log("触れたぞ");
    STOP = true;
  }
}
}
