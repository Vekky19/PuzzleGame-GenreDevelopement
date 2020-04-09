using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGoalScript : MonoBehaviour
{
    string[] colors = { "Red", "White", "Blue", "Orange", "Green", "Purple" };

    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (string col in colors)
        {
            if (collision.tag == col)
            {
                if (SceneManager.GetActiveScene().name == "Level1")
                {
                    this.GetComponent<ButtonScripts>().Game_Level2();
                }
                if (SceneManager.GetActiveScene().name == "Level2")
                {
                    this.GetComponent<ButtonScripts>().Game_Level3();
                }
                if (SceneManager.GetActiveScene().name == "Level3")
                {
                    this.GetComponent<ButtonScripts>().Game_Win();
                }

            }
        }
    }
}
