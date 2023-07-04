using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class destroy : MonoBehaviour
{
    static public bool RingIsOut;

    audioManagerScript audioManager; // look for it 

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManagerScript>(); // findes the propertise in the sound manager
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        audioManager.playSFX(audioManager.ringboom); // playes the sound effect from the sound manager 


        if (collision.tag == "BackWall")
        {           
            RingIsOut = true;
            //Debug.Log("yutch");
        }
        
    }

}



