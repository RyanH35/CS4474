using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowWin : MonoBehaviour
{
    public GameObject win;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            win.SetActive(true);
        }
    }
}
