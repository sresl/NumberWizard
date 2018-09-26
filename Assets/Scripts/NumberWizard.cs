using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Use this for initialization
    void Start()
    {

        Debug.Log("Hello Witches and Wizards, I want you to think of a Number between 1 and 1000.. " +
            "I will guess your number so you can see what an amazing Wizard I am!! So my first guess is.. " + guess);
    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            CalcGuess();

            Debug.Log("Hmmm.. Your number is lower.. My next Spell will help me find it!! So my next guess is.." + guess);
        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            CalcGuess();

            Debug.Log("Hmmm.. Your number is higher.. My next Spell will help me find it!! So my next guess is.." + guess);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("I found it! My Education at Hogwarts was worth it!!!");
        }

    }

    void CalcGuess()
    {
        guess = (min + max) / 2;

        //Debug.Log("My magical next guess is " + guess);

    }

}

