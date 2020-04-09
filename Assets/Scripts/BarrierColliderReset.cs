using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierColliderReset : MonoBehaviour
{
    public AudioClip[] clips;
    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlaySound();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
    }

    void PlaySound()
    {
        source.clip = clips[Random.Range(0, clips.Length)];
        source.Play();
    }
}
