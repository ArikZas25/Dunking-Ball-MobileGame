using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdistroy : MonoBehaviour
{
    [Header("--------- sound ---------")]
    audioManagerScript audioManager;
    public AudioSource source;
    void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("backgroundaudio").GetComponent<audioManagerScript>();
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("backgroundaudio");
        
        if (musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }
        
        DontDestroyOnLoad(this.gameObject);
        
    }
    void Start()
    {
        //audioManager.playSFX(audioManager.backgroundmusic);
    }
    private void Update()
    {
        if (!source.isPlaying)
        {
            source.Play();
        }
    }


}
