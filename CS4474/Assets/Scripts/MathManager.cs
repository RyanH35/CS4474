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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    int generateNumber()
    {
        int randomNumber = Random.Range(1, 10);
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
