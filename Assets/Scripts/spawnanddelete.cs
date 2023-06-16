using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnanddelete : MonoBehaviour
{
    public GameObject player;
    public GameObject obstacle1, obstacle2, obstacle3, obstacle4;


    public float minObstacleY;
    public float maxObstacleY;
    // Use this for initialization
    void Start()
    {
        obstacle1 = GenerateObstacle(player.transform.position.x + 4); //deffult it at + 4 
        obstacle2 = GenerateObstacle(obstacle1.transform.position.x);
        obstacle3 = GenerateObstacle(obstacle2.transform.position.x);
        obstacle4 = GenerateObstacle(obstacle3.transform.position.x);
    }

    GameObject GenerateObstacle(float x)
    {
        GameObject obstacle = GameObject.Instantiate(obstacle1);
        SetTransform(obstacle, x);
        return obstacle;
    }

    void SetTransform(GameObject obstacle, float x)
    {
        obstacle.transform.position = new Vector3(x + 6f, Random.Range(minObstacleY, maxObstacleY), obstacle.transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > obstacle2.transform.position.x)
        {
            var tempObstacle = obstacle1;
            obstacle1 = obstacle2;
            obstacle2 = obstacle3;
            obstacle3 = obstacle4;

            SetTransform(tempObstacle, obstacle3.transform.position.x);
            obstacle4 = tempObstacle;

        }
    }
}
