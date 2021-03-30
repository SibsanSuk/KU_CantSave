using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int targetScore = 1;
    public int highScore = 0;
    public UnityEvent onFinished;
    Text textScore;
    // Start is called before the first frame update

    void Awake()
    {
        textScore = GameObject.Find("Text Score").GetComponent<Text>();
        if (textScore == null)
            Debug.LogError("The game object 'Text Score' not found! please add.");

        if (PlayerPrefs.HasKey("PlayerScore"))
        {
            score = PlayerPrefs.GetInt("PlayerScore");
            textScore.text = score.ToString();
        }
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
    }

    public void ScoreIncrement()
    {
        score++;
        textScore.text = score.ToString();
        if (IsFinish())
        {
            
            onFinished.Invoke();
        }
    }

    public bool IsFinish()
    {
        if (score >= targetScore)
            return true;
        else
            return false;
    }
}
