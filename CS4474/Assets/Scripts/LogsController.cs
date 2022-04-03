using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogsController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            int answer = MathManager.mathManagerInstance.getAnswer();
            int thisnumber = int.Parse(gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().text);
            Debug.Log(answer);
            Debug.Log(thisnumber);
            if (answer == thisnumber)
            {

            }
            else
            { }
        }
    }
}
