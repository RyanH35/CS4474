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
            if (answer == thisnumber)
            {
                Music.MusicInstance.PlayRight();
            }
            else
            {
                Music.MusicInstance.PlayWrong();
                PlayerMovement pm = GameObject.Find("player").GetComponent<PlayerMovement>();
                pm.moving = false;
                pm.respawn(pm.level);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector2 pos = collision.gameObject.transform.position;
            collision.gameObject.transform.position = new Vector2(pos.x + 3 * Time.deltaTime, pos.y);
        }
    }
}
