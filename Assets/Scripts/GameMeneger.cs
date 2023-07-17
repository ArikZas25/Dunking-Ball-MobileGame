using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameMeneger : MonoBehaviour
{
    [SerializeField] private TMP_Text GameOverText;
    [SerializeField] public GameObject MenuButton; 
    [SerializeField] public GameObject player;
    [SerializeField] public static bool GameIsOver;

  


    private void Start()
    {
        MenuButton.SetActive(false);
        GameIsOver = false;
    }
    void Update()
    {
        if (destroy.RingIsOut)
        {
            GmaeOver();
        }
        else if (!destroy.RingIsOut)
        {
            continueplaying();
        }
        if (GameIsOver)
        {
            GmaeOver();
        }
       
    }
   


    public void ChangeScene(string LoadScene)
    {
        SceneManager.LoadScene(0);
    }


    private void loadScene0()
    {
        MenuButton.SetActive(true);
    }

    private void GmaeOver()
    {
        GameOverText.enabled = true;
        Invoke("loadScene0", 1f);
        player.GetComponent<movmentforplayer>().enabled = false;
    }
    private void continueplaying()
    {
        GameOverText.enabled = false;
        player.GetComponent<movmentforplayer>().enabled = true;
    }
}
