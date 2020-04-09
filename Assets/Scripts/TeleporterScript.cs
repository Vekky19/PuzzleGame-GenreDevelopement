using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterScript : MonoBehaviour
{
    public Transform tpPos;

    public bool isUsable;

    AudioSource source;

    private void Start()
    {
        isUsable = true;
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = tpPos.transform.position;
        collision.transform.position = new Vector3(collision.transform.position.x, collision.transform.position.y, 3);
        collision.GetComponent<ObjectMovement>().canMove = false;
        source.Play();

        //isUsable = false;

        //if (tpPos.GetComponent<TeleporterScript>().isUsable == true)
        //{
        //    collision.transform.position = tpPos.transform.position;
        //    tpPos.GetComponent<TeleporterScript>().isUsable = false;
        //}
    }
}
