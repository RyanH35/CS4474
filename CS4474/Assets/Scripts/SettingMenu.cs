using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SettingMenu : MonoBehaviour
{
    public static SettingMenu menuSettings;
    void Awake()
    {
        if (menuSettings != null)
        {
            GameObject.Destroy(menuSettings.gameObject);
        }
        else
            menuSettings = this;
    }

    public string difficulty = "medium";
    public int length_int = 60;
    public float volume_value = 30;
    public Slider length;
    public Text voulmeText;
    public Slider volume;
    
    public void Easy()
    {
        difficulty = "easy";
    }

    public void Medium()
    {
        difficulty = "medium";
    }
    
    public void Hard()
    {
        difficulty = "hard";
    }

    public void GameLength()
    {
        if(length.value == 0)
        {
            length_int = 60;
        }
        else if(length.value == 1)
        {
            length_int = 90;
        }
        else if (length.value == 2)
        {
            length_int = 120;
        }
        else if (length.value == 3)
        {
            length_int = 150;
        }
        else
        {
            length_int = 180;
        }
    }

    public void VolumeControl()
    {
        volume_value = volume.value;
        if (volume_value==0)
        {
            AudioListener.volume = volume_value;
        }
        else
        {
            AudioListener.volume = volume_value/15;
        }
        
        voulmeText.text = "Current Volume: " + volume_value +"%";
    }
}
