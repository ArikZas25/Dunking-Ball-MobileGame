using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomspawning : MonoBehaviour
{

    [SerializeField] private GameObject[] objectsToInstatiate;


    [SerializeField] private GameObject player;
   void Start()
    {
        int n = Random.Range(0, objectsToInstatiate.Length);
      
        float x = Random.Range(player.transform.position.x + 4, 5);
        float y = Random.Range(-4, 4);
        Instantiate(objectsToInstatiate[n], new Vector2(x, y), Quaternion.identity);

    }

  
}




  

