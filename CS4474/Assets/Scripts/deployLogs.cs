using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployLogs : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject logPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(logWave());
    }
    private void spawnLogs() {
        GameObject a= Instantiate(logPrefab) as GameObject;
        
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-20, -29));
       
    }
    IEnumerator logWave() {
        while (true) {
            yield return new WaitForSeconds(respawnTime);
            spawnLogs();
        }
    }

    // Update is called once per frame
    
}
