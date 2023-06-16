using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject[] RingPreFab;
    [SerializeField] GameObject Spawner;
    [SerializeField] float secondSpawn = 2f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;
    void Start()
    {
        StartCoroutine(RingSpawn());
    }

    IEnumerator RingSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(RingPreFab[Random.Range(0, RingPreFab.Length)], position, Quaternion.identity); ;
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 3f);
        }
    }
}
