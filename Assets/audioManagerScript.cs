using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManagerScript : MonoBehaviour
{

    [Header("---------- Audio Source ----------")]
    [SerializeField] AudioSource SfxSource;

    [Header("---------- Audio Clip ----------")]
    public AudioClip ringboom;
    public AudioClip jumpsound;



    public void playSFX(AudioClip clip)
    {
        SfxSource.PlayOneShot(clip);
    }
}
