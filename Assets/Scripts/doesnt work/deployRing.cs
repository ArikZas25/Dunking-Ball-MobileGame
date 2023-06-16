using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class deployRing : MonoBehaviour
{
    public GameObject ringPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(ringwave());
    }
    private void spawnRings()
    {
        //var wanted = Random.Range(2, -2);
        //var position = new Vector3(transform.position.y, wanted);
        GameObject A = Instantiate(ringPrefab) as GameObject;
        //GameObject A = Instantiate(ringPrefab[Random.Range(0, ringPrefab.Length)], position, Quaternion.identity);
        A.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }
  IEnumerator ringwave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnRings();
        }
    }
}
