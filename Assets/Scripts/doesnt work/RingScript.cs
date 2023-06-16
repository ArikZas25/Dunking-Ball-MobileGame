using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    void Start()
    {
      rb = this.GetComponent<Rigidbody2D>();
      screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    
    void Update()
    {
        if(transform.position.x < screenBounds.x * 2){
            Destroy(this.gameObject);
        }
    }
}
