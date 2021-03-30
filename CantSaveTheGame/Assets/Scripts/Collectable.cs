using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    GameManager gm;
    void Awake()
    {
        gm = FindObjectOfType<GameManager>();
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            gm.ScoreIncrement();
            Destroy(gameObject);
        }
    }
}
