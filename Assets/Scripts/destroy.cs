using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class destroy : MonoBehaviour
{
  static public bool RingIsOut;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

 
        if (collision.tag == "BackWall")
        {           
            RingIsOut = true;
            //Debug.Log("yutch");
        }
        
    }
}
