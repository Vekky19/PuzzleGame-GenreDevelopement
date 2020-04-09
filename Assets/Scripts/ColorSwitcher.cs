using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitcher : MonoBehaviour
{
    public Color color;
    GameObject switchT;
    Vector3 origionalS;
    int growSize = 1;

    void Start()
    {
        switchT = this.gameObject;
        origionalS = switchT.transform.localScale;

        if (this.tag == "Blue")
        {
            color = new Color(0, 255, 255, 255);
        }
        else if (this.tag == "Red")
        {
            color = new Color(255, 0, 0, 255);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<ObjectColorManager>().ChangeColor(color);
        collision.tag = this.tag;
        this.GetComponent<ColorSwitcherAudio>().PlaySound();
        SwitchingColor();
    }

    void SwitchingColor()
    {
        switchT.transform.localScale = new Vector3(switchT.transform.localScale.x + growSize, switchT.transform.localScale.y + growSize, switchT.transform.localScale.z);
    }

    void Update()
    {
        if (switchT.transform.localScale.x > origionalS.x)
        {
            switchT.transform.localScale = new Vector3(switchT.transform.localScale.x - 3 * Time.deltaTime, switchT.transform.localScale.y, origionalS.z);
        }
        if (switchT.transform.localScale.y > origionalS.y)
        {
            switchT.transform.localScale = new Vector3(switchT.transform.localScale.x, switchT.transform.localScale.y - 3 * Time.deltaTime, origionalS.z);
        }
    }
}
