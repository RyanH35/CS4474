using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Gameplay1");
    }

    public void SettingButton()
    {
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
