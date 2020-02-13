using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Buttons : MonoBehaviour {

    public UIHandlerHiragana UIH;
    public UIHandlerDakuten UID;
    public UIHandlerCombo UIC;
    public UIHandlerAll UIA;
    public UIHandlerInfinite UII;

    public void onClickQuit()   // when button is pressed
    {
        Application.Quit();     // quit the entire game
    }

    public void onClickBack()   // when button is pressed
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single); // load the main menu
    }

    public void onClickPlay()
    {
        SceneManager.LoadScene("Difficulty", LoadSceneMode.Single); // load the difficulty menu
    }

    public void onClickHiraganaMenu()
    {
        SceneManager.LoadScene("HiraganaMenu", LoadSceneMode.Single); // load hiragana
    }

    public void onClickHiragana()
    {
        SceneManager.LoadScene("Hiragana", LoadSceneMode.Single); // load hiragana
    }

    public void onClickDakutenMenu()
    {
        SceneManager.LoadScene("DakutenMenu", LoadSceneMode.Single); // load Dakuten
    }

    public void onClickDakuten()
    {
        SceneManager.LoadScene("Dakuten", LoadSceneMode.Single); // load Dakuten
    }

    public void onClickComboMenu()
    {
        SceneManager.LoadScene("ComboMenu", LoadSceneMode.Single); // load Combo
    }

    public void onClickCombo()
    {
        SceneManager.LoadScene("Combo", LoadSceneMode.Single); // load Combo
    }

    public void onClickAllMenu()
    {
        SceneManager.LoadScene("AllMenu", LoadSceneMode.Single); // load All
    }

    public void onClickAll()
    {
        SceneManager.LoadScene("All", LoadSceneMode.Single); // load All
    }

    public void onClickInfinite()
    {
        SceneManager.LoadScene("Infinite", LoadSceneMode.Single); // load Infinite
    }

    public void onClickInfiniteDakuten()
    {
        SceneManager.LoadScene("InfiniteDakuten", LoadSceneMode.Single); // load Infinite
    }

    public void onClickInfiniteCombo()
    {
        SceneManager.LoadScene("InfiniteCombo", LoadSceneMode.Single); // load Infinite
    }

    public void onClickInfiniteAll()
    {
        SceneManager.LoadScene("InfiniteAll", LoadSceneMode.Single); // load Infinite
    }

    public void onClickChart()
    {
        SceneManager.LoadScene("Chart", LoadSceneMode.Single); // load the alphabet chart
    }

    /*public void onClickCheat()
    {
        UIA.numComp = 45;
        UIN.numComp = 45;
    }*/
}
