using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHandlerInfiniteCombo : MonoBehaviour
{
    public ImageReplacer im;        //allows you to use variables and functions from the ImageReplacer Script
    public InputField textField;    //detects the InputField the user types into
    public Text Hintt;
    public int numComp = 0;
    public int fails = 0;
    public string character;
    public string input;
    public string currentSprite;
    public char firstLetter;
    public GameObject Correct;
    public GameObject TryAgain;
    public GameObject WellDone;
    public GameObject WellDoneBacking;
    public GameObject InputField;
    public GameObject Hint;
    public GameObject Quit;
    public GameObject Back;
    public GameObject mImage;


    private void Start()
    {
        GameObject Correct = GameObject.Find("Correct");
        GameObject TryAgain = GameObject.Find("TryAgain");
        GameObject WellDone = GameObject.Find("WellDone");
        GameObject WellDoneBacking = GameObject.Find("WellDoneBacking");
        GameObject InputField = GameObject.Find("InputField");
        GameObject Quit = GameObject.Find("Quit");
        GameObject Back = GameObject.Find("Back");
        GameObject mImage = GameObject.Find("Image");
        GameObject Hint = GameObject.Find("Hint");
        Correct.SetActive(false);
        TryAgain.SetActive(false);
        WellDone.SetActive(false);
        Back.SetActive(false);
        WellDoneBacking.SetActive(false);
        Hint.SetActive(false);
        InputField.SetActive(true);
        Quit.SetActive(true);
        mImage.SetActive(true);
    }

    private void Update()
    {
        currentSprite = im.spriteRenderer.sprite.name;      //gets the current sprite from the ImageReplacer and makes it a string
        char[] spriteArray = currentSprite.ToCharArray();
        firstLetter = spriteArray[0];
        //Debug.Log("Sprite Name: " + currentSprite);
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
            numComp++;
            fails = 0;
            if(!im.ChangeTheDamnSprite() || numComp >= im.spritearray.Length)
            {
                im.GoAgain();
                numComp = 0;
            }
            
            /*if (!im.ChangeTheDamnSprite() || numComp >= 46)
            {
                Debug.Log("Well Done! You did it");
                Correct.SetActive(false);
                TryAgain.SetActive(false);
                mImage.SetActive(false);
                Quit.SetActive(false);
                InputField.SetActive(false);
                WellDoneBacking.SetActive(true);
                WellDone.SetActive(true);
                Back.SetActive(true);
                OutOf.SetActive(false);
            }
            //calls the fuction in the ImageReplacer Script*/
        }
        else
        {
            Correct.SetActive(false);
            TryAgain.SetActive(true);
            Debug.Log("Try again");         //tells them to try again if they fail
            fails = fails + 1;
        }
    }
}
