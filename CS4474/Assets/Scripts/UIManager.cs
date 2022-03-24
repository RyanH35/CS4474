using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager UIManagerInstance {get; private set;}
    public Text firstNumberText;
    public Text secondNumberText;

    public Text timeLeftText;
    public float timeLeft;
    private float maxQuestionTime = 60f;

    public GameObject gameOverMenu;

    // Start is called before the first frame update
    void Start()
    {

        //get max question time from game settings
        //maxQuestionTime = GameManager.gameManagerInstance.VAR
        //TODO
        timeLeft = maxQuestionTime;
        firstNumberText.text = MathManager.mathManagerInstance.firstNumber.ToString();
        secondNumberText.text = MathManager.mathManagerInstance.secondNumber.ToString();
        gameOverMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //update the bar that represents the time left
        timeLeftText.text = ((int)timeLeft).ToString();
        timeLeft -= Time.deltaTime;
        TimerBar.barInstance.SetValue(timeLeft / maxQuestionTime);
    }

    public void updateNumbers()
    {
        firstNumberText.text = MathManager.mathManagerInstance.firstNumber.ToString();
        secondNumberText.text = MathManager.mathManagerInstance.secondNumber.ToString();
    }
}
