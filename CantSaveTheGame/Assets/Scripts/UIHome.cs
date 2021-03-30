using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIHome : MonoBehaviour
{
    Text textHighScore;
    
    void Start()
    {
        textHighScore = GameObject.Find("Text High Score").GetComponent<Text>();
        if (PlayerPrefs.HasKey("HighScore"))
        {
            var score = PlayerPrefs.GetInt("HighScore");
            textHighScore.text = score.ToString();
        }
    }
    public void StartGame()
    {
        PlayerPrefs.SetInt("PlayerScore", 0);
        SceneManager.LoadScene("Level0");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
