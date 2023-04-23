using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject mainMenu;
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OptionsButton()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void BackButton()
    {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void QuitButton()
    {
        Debug.Log("The Game has been Quit.");
        Application.Quit();
    }
}
