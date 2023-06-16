using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class destroy : MonoBehaviour
{
  static public bool RingIsOut = false;
    /*
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
        RingIsOut = true;
    }
    */
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
