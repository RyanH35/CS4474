using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //check for answer from player
        //answer comes from player character stepping on an object
        //TODO
        //if(MathManager.mathManagerInstance.checkAnswer(VARFROMLOG))
        //else destroy log

        if(UIManager.UIManagerInstance.timeLeft < 0)
        {
            //show correct answer and game over screen
            //TODO
            //UIManager.UIManagerInstance.gameOverMenu.SetActive(true);
            //MathManager.mathManagerInstance.getAnswer();
        }

    }

    void updateNumbers()
    {
        //update the actual number first
        MathManager.mathManagerInstance.updateNumbers();
        //then update the visual representation of the numbers
        UIManager.UIManagerInstance.updateNumbers();
    }
}
