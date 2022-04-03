using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogsManager: MonoBehaviour
{
    public static LogsManager LogsManagerInstance { get; private set; }
    public GameObject prefab;
    GameObject[] logs;
    int[] levels = { 3,20,37,54};
    public int current_level;
    GameObject RealWorld;
    // Start is called before the first frame update
    void Start()
    {
        LogsManagerInstance = this;
        RealWorld = GameObject.Find("RealWorld");
        current_level = 0;
        InitLogs();
    }

    public void InitLogs()
    {
        logs = new GameObject[5];
        for (int i = 0; i < 5; i++)
        {
            logs[i] = Instantiate(prefab, new Vector3(-28 - i * 10, levels[current_level], 0), Quaternion.identity);
            logs[i].transform.parent = RealWorld.transform;
            int number = MathManager.mathManagerInstance.getAnswer() + Offset();
            logs[i].GetComponentInChildren<TextMeshProUGUI>().text = number.ToString();
        }
        logs[Random.Range(0, 4)].GetComponentInChildren<TextMeshProUGUI>().text = MathManager.mathManagerInstance.getAnswer().ToString();
    }

    int Offset()
    {
        int randomNumber;
        if (PlayerSettings.playerSettings.difficulty == "hard")
        {
            randomNumber = Random.Range(-15, 15);
        }
        else if (PlayerSettings.playerSettings.difficulty == "medium")
        {
            randomNumber = Random.Range(-10, 10);
        }
        else
        {
            randomNumber = Random.Range(-5, 5);
        }
        return randomNumber;
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector2 pos = logs[i].transform.position;
            if (pos.x > 28)
                pos.x = -
                    28;
            logs[i].transform.position = new Vector2(pos.x + 3 * Time.deltaTime, pos.y);
        }
    }

}
