using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawning : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int objectCount;
    public int yPosition;
    public int xPosition;
    public int Distance;

    void Start()
    {

        objectCount = 5;
        yPosition = 0;
        xPosition = 0;
        Distance = 2;

        for (int i = 0; i < objectCount; i++)
        {
            Instantiate(objectToSpawn, new Vector2(0, yPosition), Quaternion.identity);
            yPosition += Distance;
            Instantiate(objectToSpawn, new Vector2(xPosition, 0), Quaternion.identity);
            xPosition += Distance;
        }
    }
}
