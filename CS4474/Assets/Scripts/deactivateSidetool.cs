using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deactivateSidetool : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sideBar;
    void Start()
    {
        sideBar.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKey(KeyCode.P)) {
            sideBar.SetActive(false);   
        }
        if (Input.GetKey(KeyCode.O)) {
            sideBar.SetActive(true);
        }
        
    }
}
