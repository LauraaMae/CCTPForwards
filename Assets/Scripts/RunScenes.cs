using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunScenes : MonoBehaviour
{

// Creating functions to load seperate scenes
    public void PlayStreet()
    {
        SceneManager.LoadSceneAsync("Street");
    }

    public void PlayOffice()
    {
        SceneManager.LoadSceneAsync("Office");
    }


    public void PlayHomeA()
    {
        SceneManager.LoadSceneAsync("HomeA");
    }


    public void PlayHomeB()
    {
        SceneManager.LoadSceneAsync("HomeB");
    }

    public void PlayTransport()
    {
        SceneManager.LoadSceneAsync("Transport");
    }

    public void LoadMenu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

//Function made for Quiting the Game
    public void QuitGame()
     {
        Application.Quit();
     }

}
