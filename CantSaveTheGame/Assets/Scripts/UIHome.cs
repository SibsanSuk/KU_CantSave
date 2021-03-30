using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHome : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level0");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
