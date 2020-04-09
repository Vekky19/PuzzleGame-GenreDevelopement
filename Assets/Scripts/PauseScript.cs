using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    bool paused = false;

    public Button[] buttons;
    public Image image;

    public void changePaused()
    {
        paused = !paused;
    }

    void EnablePause()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].enabled = true;
            buttons[i].transform.position = new Vector3(500, buttons[i].transform.position.y);
        }
        image.enabled = true;
    }

    void DisablePause()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].transform.position = new Vector3(15000, buttons[i].transform.position.y);
        }
        image.enabled = false;
    }

    void Update()
    {
        if (paused == true)
        {
            Time.timeScale = 0;
            EnablePause();
        }
        else
        {
            Time.timeScale = 1f;
            DisablePause();
        }
    }
}
