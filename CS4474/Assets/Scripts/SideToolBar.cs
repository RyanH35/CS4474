using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SideToolBar : MonoBehaviour
{
    public bool Mute = false;
    public bool Pause = false;

    public Button Mbutton;
    public Button Pbutton;

    public Sprite PImage;
    public Sprite UPImage;

    public Sprite MImage;
    public Sprite UImage;


    public void MuteButton()
    {
        if (Mute == false)
        {
            AudioListener.volume = 0;
            Mbutton.image.sprite = MImage;
            Mute = true;
        }
        else
        {
            AudioListener.volume = 1;
            Mbutton.image.sprite = UImage;
            Mute = false;
        }
    }

    public void PauseButton()
    {
        if(Pause == false)
        {
            Time.timeScale = 0;
            Pbutton.image.sprite = PImage;
            Pause = true;
            print("pasued");
        }
        else
        {
            Time.timeScale = 1;
            Pbutton.image.sprite = UPImage;
            Pause = false;
            print("back");
        }
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("reseted");
    }
    
     public void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
