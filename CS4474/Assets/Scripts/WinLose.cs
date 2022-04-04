using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinLose : MonoBehaviour
{
    // Start is called before the first frame update
    public void restart()
    {
        SceneManager.LoadScene("Gameplay1");
    }

    // Update is called once per frame
    public void mainmenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
