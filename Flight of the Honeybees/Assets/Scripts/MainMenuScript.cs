using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour
{
    //Start Button on Main Menu
    public void StartButton1()
    {
        SceneManager.LoadScene(2);
    }

    //Start Button on Tutorial
    public void StartButton2()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        Debug.Log("The Game has been Quit.");
        Application.Quit();
    }
}
