using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerMovement pm = collision.gameObject.GetComponent<PlayerMovement>();
            if (!pm.moving)
            {
                Music.MusicInstance.PlayWaterFall();
                pm.moving = false;
                pm.respawn(pm.level);
            }
        }
    }
}
