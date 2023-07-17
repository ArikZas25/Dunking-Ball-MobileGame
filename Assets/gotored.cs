using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class gotored : MonoBehaviour
{
    [SerializeField] private Material myMaterial;

    private void OnTriggerEnter2D(Collider2D collision)
    {
   
            if (collision.tag == "player")
            {
                myMaterial.color = Color.red;

            }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.tag == "player")
        {
            myMaterial.color = Color.yellow;

        }

    }


}
