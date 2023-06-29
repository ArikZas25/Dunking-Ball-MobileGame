using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class GameMeneger : MonoBehaviour
{
    [SerializeField] private TMP_Text GameOverText;
    [SerializeField] private TextMeshProUGUI MenuButton; //does not conect to the tmpro button
    [SerializeField] private GameObject player;


    private void Start()
    {
        MenuButton.enabled = false;
    }
    void Update()
    {
        if (destroy.RingIsOut)
        {
            GameOverText.enabled = true;
            MenuButton.enabled = true;
            player.GetComponent<movmentforplayer>().enabled = false;
        }
    }
}
