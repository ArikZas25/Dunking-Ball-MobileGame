using System.Collections;
using UnityEngine;


public class PlayerMovment : MonoBehaviour{

    [SerializeField]
    public float jumpVelocity; //the hight of the jump

    public float speed = 2f;
    public float speedtap = 2f;
    public float fallMultiplier = 2.5f; //the strengh of the gravity when the player falls
    public float lowjumpMultiplier = 2f;
    public Rigidbody2D rb;

    public float direction = 1;
    
    void Update() 
    {
       
        if (rb.velocity.y < 0) // add grater gravity when the ball falls
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        } else if (rb.velocity.y > 0  &&  Input.GetMouseButtonDown(0))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowjumpMultiplier - 1) * Time.deltaTime;
        }

     if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpVelocity;
            //rb.AddForce(Vector2.up * Time.deltaTime * jumpVelocity);
            //rb.AddForce(Vector2.right * speedtap);
           
            //Invoke("Jumprightontap", 0.1f);
        }
    }

    private void FixedUpdate() //problem the ball climes the rings
    {
        rb.velocity = new Vector2(speed * direction * Time.deltaTime, rb.velocity.y);   
       
    }

    //void Jumprightontap()
    //{
        //rb.AddForce(Vector2.right * Time.deltaTime * speedtap);
   //}
    
}
