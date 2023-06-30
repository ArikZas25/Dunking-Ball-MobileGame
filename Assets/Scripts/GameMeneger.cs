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
    [SerializeField] public GameObject MenuButton; //does not conect to the tmpro button
    [SerializeField] private GameObject player;


    private void Start()
    {
        MenuButton.SetActive(false);
    }
    void Update()
    {
        if (destroy.RingIsOut)
        {
            GameOverText.enabled = true;
            MenuButton.SetActive(true);
            player.GetComponent<movmentforplayer>().enabled = false;
        }
    }

    public void ChangeScene(string LoadScene)
    {
        SceneManager.LoadScene(0);
    }
}
