using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcherAudio : MonoBehaviour
{
    public AudioClip[] clips;
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        source.clip = clips[Random.Range(0, clips.Length)];
        source.Play();
    }
}
