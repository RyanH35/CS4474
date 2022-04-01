using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathManager : MonoBehaviour
{
    public static MathManager mathManagerInstance {get; private set;}

    public int firstNumber;
    public int secondNumber;

    void Awake()
    {
        mathManagerInstance = this;
        firstNumber = generateNumber();
        secondNumber = generateNumber();
    }

    int generateNumber()
    {
        int randomNumber;
        if(PlayerSettings.playerSettings.difficulty == "hard")
        {
            randomNumber = Random.Range(2, 15);
        }
        else if(PlayerSettings.playerSettings.difficulty == "medium")
        {
            randomNumber = Random.Range(1, 10);
        }
        else
        {
            randomNumber = Random.Range(1, 5);
        }
        return randomNumber;
    }

    public bool checkAnswer(int answer)
    {
        return (answer == firstNumber * secondNumber); 
    }

    public void updateNumbers()
    {
        firstNumber = generateNumber();
        secondNumber = generateNumber();
    }

    public int getAnswer()
    {
        return firstNumber * secondNumber;
    }
}
