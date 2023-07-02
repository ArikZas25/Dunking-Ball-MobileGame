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
    [SerializeField] private GameObject player;


    private void Start()
    {
        MenuButton.SetActive(false);
    }
    void Update()
    {
        if (destroy.RingIsOut)
        {
            menuMenegerScript.GameOverBool = true; // added hear athe menuMenegerScript.GameOverBool = true; 
            GameOverText.enabled = true;
            Invoke("loadScene0", 1f);
            player.GetComponent<movmentforplayer>().enabled = false;

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
}
