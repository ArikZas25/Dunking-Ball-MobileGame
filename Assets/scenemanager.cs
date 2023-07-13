using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
   

    void Start()
    {
        //audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManagerScript>();
      
        SceneManager.LoadScene(1);
    }

}
