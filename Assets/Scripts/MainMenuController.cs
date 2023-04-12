using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Author()
    {
        Debug.Log("Created By Robbi Adam");
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}