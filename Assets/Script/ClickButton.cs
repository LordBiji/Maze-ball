using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickButton : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("labirin");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Labirin");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}