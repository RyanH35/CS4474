using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    public string difficulty;
    public int timerLength;

    public static PlayerSettings playerSettings;
    void Awake()
    {
        if(playerSettings != null)
        {
            GameObject.Destroy(playerSettings.gameObject);
        }
        else
        {
            playerSettings = this;
        }
        DontDestroyOnLoad(this);
    }

    public void setValues()
    {
        try
        {
            difficulty = SettingMenu.menuSettings.difficulty;
            timerLength = SettingMenu.menuSettings.length_int;;
        }
        //default settings
        catch
        {
            difficulty = "medium";
            timerLength = 60;
        }
    }

}
