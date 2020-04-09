using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    Transform obj;
    Rigidbody2D objRB;
    public bool canMove;

    void Start()
    {
        obj = GetComponent<Transform>();
        objRB = GetComponent<Rigidbody2D>();

        canMove = false;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {   
        if (collision.gameObject.tag == "Teleporter")
        {
            //StartCoroutine(Cooldown());
        }
        else if (obj.gameObject.tag != collision.gameObject.tag)
        {
            canMove = false;
            GameObject collider = collision.gameObject;
            collider.GetComponent<BoxCollider2D>().isTrigger = false;
        }
        else
        {
            canMove = true;
            GameObject collider = collision.gameObject;
            collider.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            canMove = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            canMove = false;
        }
    }
    
    void MoveObj()
    {
        Vector2 velocity = Camera.main.ScreenToWorldPoint(Input.mousePosition) - obj.position;
        objRB.MovePosition(objRB.position + velocity);
    }

    void FixedUpdate()
    {
        if (canMove == true)
        {
            MoveObj();
        }
    }
}
