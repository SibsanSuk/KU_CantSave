using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeadArea : MonoBehaviour
{
    public UnityEvent onDead;

    void OnTriggerEnter(Collider collider)
    {
        print("Dead");
        if(collider.gameObject.tag == "Player")
        {
            print("Dead");
            onDead.Invoke();
        }
    }
}
