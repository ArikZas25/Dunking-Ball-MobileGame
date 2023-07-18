using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class movmentforplayer : MonoBehaviour
{
    [Header("--------- movement ---------")]
    [SerializeField] private float Speed; 
    [SerializeField] private float JumpForce;
    [SerializeField] private float TapForceStrengh;
    [SerializeField] private float MaxSpeed;
    [SerializeField] private float Maxgamespeed;
    
    [Header("--------- other ---------")]
    //[SerializeField] private int direction = 1; // should change it 
    [SerializeField] private Rigidbody2D rb;

    [Header("--------- sound ---------")]
    audioManagerScript audioManager;

    [Header("--------- ring spawn ---------")]
    [SerializeField] private GameObject[] objectsToInstatiate;

    [Header("--------- prefab ---------")]
    [SerializeField] private GameObject player;
  
    [Header("--------- GameOver ---------")]
    [SerializeField] private TMP_Text GameOverText;

    [Header("--------- color ---------")]
    [SerializeField] private Material myCelingMaterial;
    [SerializeField] private Material myFloorMaterial;
    [SerializeField] private Material defultMat;


    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManagerScript>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameOverText.enabled = false;
        myCelingMaterial.color = defultMat.color;
        myFloorMaterial.color = defultMat.color;



    }
    private void FixedUpdate()
    {
        if (rb.velocity.magnitude < MaxSpeed)
        {
            RightForce(); //adds right force when needed
        } 
    }
    void Update()
    {
        //Debug.Log(rb.velocity.magnitude);
        if (rb.velocity.magnitude > Maxgamespeed)
        {
            MaxGameSpeed(); //hard cam on the max speed of the game
        }
        if (Input.GetMouseButtonDown(0))
        {
            Jump(); // triggers void jump 

            if (rb.velocity.magnitude > MaxSpeed) 
            {
                maxspeed(); // adds a max speed so the player wont go over the velosity set amount
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) //make it on a GotPoint // make it on trigger and not on colision
    {
        InstantiateObject();
    }
    




    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0); //makes the gravity wont work when jumping
        rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse); //adds force up
        rb.AddForce(Vector2.right * TapForceStrengh * Time.deltaTime, ForceMode2D.Impulse); //force right on tap
        audioManager.playSFX(audioManager.jumpsound); // playes the Jumpsound from the audio Manager 
    }
    void RightForce()
    {
        rb.AddForce(Vector2.right * Speed * Time.deltaTime, ForceMode2D.Impulse);
    }
    void maxspeed()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxSpeed);
    }
    void MaxGameSpeed()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, Maxgamespeed);
        
    }
    private void InstantiateObject()
    {
        print("trigger!");
        float x = Random.Range(player.transform.position.x + 5, player.transform.position.x + 7);

        float y = Random.Range(-4, 4);

        int n = Random.Range(0, objectsToInstatiate.Length);

        Instantiate(objectsToInstatiate[n], new Vector2(x, y), Quaternion.identity);
    }
}
