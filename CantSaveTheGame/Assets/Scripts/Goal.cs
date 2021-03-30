using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public string nextSceneName;
    GameManager gm;

    void Awake()
    {
        gm = FindObjectOfType<GameManager>();
        gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            PlayerPrefs.SetInt("PlayerScore", gm.score);
            if(gm.score > gm.highScore)
            {
                PlayerPrefs.SetInt("HighScore", gm.score);
            }

            SceneManager.LoadScene(nextSceneName);
        }
    }
}
