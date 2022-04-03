using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningLogs : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    private Rigidbody2D rb;
    //private Vector2 screenBounds;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(waitForDestroy());
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }
    private IEnumerator waitForDestroy()
    {
        yield return new WaitForSeconds(15);
        Destroy(this.gameObject);
    }
}
