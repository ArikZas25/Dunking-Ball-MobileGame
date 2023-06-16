using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Transform player;
    float offsetX;
    // Use this for initialization
    void Start()
    {
        GameObject player_go = GameObject.FindGameObjectWithTag("Player");
        if (player_go == null)
            return;
        player = player_go.transform;
        offsetX = transform.position.x - player.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 pos = transform.position;
            pos.x = player.position.x + offsetX;
            transform.position = pos;
        }
    }
}
