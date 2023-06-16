using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameMeneger : MonoBehaviour
{
    [SerializeField] private TMP_Text GameOverText;
    [SerializeField] private GameObject player;

    void Update()
    {
        if (destroy.RingIsOut)
        {
            GameOverText.enabled = true;
            player.GetComponent<movmentforplayer>().enabled = false;
        }
    }
}
