using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManagerScript : MonoBehaviour
{

    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource SfxSource;
    [SerializeField] AudioSource backgroundmusicsource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip ringboom;
    public AudioClip jumpsound;
    public AudioClip backgroundmusic;


    public void playSFX(AudioClip clip)
    {
        SfxSource.PlayOneShot(clip);
    }
    private void Start()
    {
        backgroundmusicsource.clip = backgroundmusic;
        backgroundmusicsource.Play();
    }
}
