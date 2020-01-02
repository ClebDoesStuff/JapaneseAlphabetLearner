using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandlerHiragana : MonoBehaviour {

    public ImageReplacer im;        //allows you to use variables and functions from the ImageReplacer Script
    public InputField textField;    //detects the InputField the user types into
    public Text Scoret;
    public Text ScoreOutOft;
    public Text OutOft;
    public Text Hintt;
    public int numComp = 0;
    public int fails = 0;
    public string character;
    public string input;
    public string currentSprite;
    public char firstLetter;
    public int score = 0;
    public GameObject Correct;
    public GameObject TryAgain;
    public GameObject WellDone;
    public GameObject WellDoneBacking;
    public GameObject Score;
    public GameObject ScoreOutOf;
    public GameObject InputField;
    public GameObject Hint;
    public GameObject Quit;
    public GameObject Back;
    public GameObject mImage;
    public GameObject OutOf;
    public GameObject PScore;


    private void Start()
    {
        score = 0;
        GameObject Correct = GameObject.Find("Correct");
        GameObject TryAgain = GameObject.Find("TryAgain");
        GameObject WellDone = GameObject.Find("WellDone");
        GameObject WellDoneBacking = GameObject.Find("WellDoneBacking");
        GameObject ScoreOutOf = GameObject.Find("ScoreOutOf");
        GameObject InputField = GameObject.Find("InputField");
        GameObject Quit = GameObject.Find("Quit");
        GameObject Back = GameObject.Find("Back");
        GameObject mImage = GameObject.Find("Image");
        GameObject Score = GameObject.Find("Score");
        GameObject OutOf = GameObject.Find("OutOf");
        GameObject Hint = GameObject.Find("Hint");
        GameObject PScore = GameObject.Find("PScore");
        Correct.SetActive(false);
        TryAgain.SetActive(false);
        WellDone.SetActive(false);
        Back.SetActive(false);
        WellDoneBacking.SetActive(false);
        ScoreOutOf.SetActive(false);
        Hint.SetActive(false);
        InputField.SetActive(true);;
        Quit.SetActive(true);
        mImage.SetActive(true);
        Score.SetActive(true);
        PScore.SetActive(false);
        OutOf.SetActive(true);
    }

    private void Update()
    {
        currentSprite = im.spriteRenderer.sprite.name;      //gets the current sprite from the ImageReplacer and makes it a string
        char[] spriteArray = currentSprite.ToCharArray();
        firstLetter = spriteArray[0];
        //Debug.Log("Sprite Name: " + currentSprite);
        Scoret.text = "Score: " + score;
        OutOft.text = numComp + "/" + im.spritearray.Length;
        if (fails >= 3)
        {
            Hintt.text = "The answer starts with a/an " + firstLetter + ".";
            Hint.SetActive(true);
        }
        else
        {
            Hint.SetActive(false);
        }
    }

    public void ontype()
    {
        
    }

    public void onfinish()
    {
        characterDetection();
        textField.Select();
        textField.text = "";
    }

    public void characterDetection()
    {
        Debug.Log("You typed: " + textField.text);
        input = textField.text;
        character = input.ToLower();         //set the variable character to whatever the user inputs
        Debug.Log("Now you typed: " + character);

        if (character == currentSprite)     //checks to see if the user input and the current sprite are the same
        {
            TryAgain.SetActive(false);
            Correct.SetActive(true);
            Debug.Log("Correct");           //congratulates them if they get the right word
            score = score + 50;             //adds to score
            numComp++;
            fails = 0;
            if (!im.ChangeTheDamnSprite() || numComp >= im.spritearray.Length)
            {
                Debug.Log("Well Done! You did it");
                if (score == 2300)
                {
                    ScoreOutOft.text = "You scored " + score + "/2300";
                    PScore.SetActive(true);
                }
                else
                {
                    ScoreOutOft.text = "You scored " + score + "/2300";
                }
                
                Correct.SetActive(false);
                TryAgain.SetActive(false);
                mImage.SetActive(false);
                Quit.SetActive(false);
                InputField.SetActive(false);
                WellDoneBacking.SetActive(true);
                WellDone.SetActive(true);
                Back.SetActive(true);
                ScoreOutOf.SetActive(true);
                Score.SetActive(true);
                OutOf.SetActive(false);
            }
                //calls the fuction in the ImageReplacer Script
        }
        else
        {
            Correct.SetActive(false);
            TryAgain.SetActive(true);
            Debug.Log("Try again");         //tells them to try again if they fail
            score = score - 50;             //takes from score
            fails = fails + 1;
        }
    }
}
