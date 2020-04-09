using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{

    public void Game_Start()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Game_Quit()
    {
        Application.Quit();
    }

    public void Game_Level2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void Game_Level3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void Game_Win()
    {
        SceneManager.LoadScene("Victory");
    }

    public void Game_Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Game_Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
