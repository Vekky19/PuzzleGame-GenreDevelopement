using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectColorManager : MonoBehaviour
{
    Color objColor;
    public SpriteRenderer objSpriteRend;

    int cameraZoomSpeed = 5;

    void Start()
    {
        objColor = new Color(255, 255, 255, 255);
        objSpriteRend = GetComponent<SpriteRenderer>();
    }

    public void ChangeColor(Color newColor)
    {
        objSpriteRend.color = newColor;
    }

    private void Update()
    {
        if (Input.GetAxis("MouseScrollWheel") > 0)
        {
            Camera.main.orthographicSize -= Time.deltaTime * cameraZoomSpeed;
        }
        else if (Input.GetAxis("MouseScrollWheel") < 0)
        {
            Camera.main.orthographicSize += Time.deltaTime * cameraZoomSpeed;
        }
    }
}
