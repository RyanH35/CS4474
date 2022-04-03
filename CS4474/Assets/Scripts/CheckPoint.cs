using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public int level_num;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            MathManager.mathManagerInstance.updateNumbers();
            UIManager.UIManagerInstance.updateNumbers();
            LogsManager.LogsManagerInstance.current_level = level_num;
            LogsManager.LogsManagerInstance.InitLogs();
            Destroy(gameObject);
        }
    }
}
