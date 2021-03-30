using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 1f;
    public float jumpPower = 5f;
    public AudioSource audioJump;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
            Debug.LogError("RB not found!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            print("Jump");
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            audioJump.Play();
        }
        
    }

    void FixedUpdate()
    {
        var horizontal = Input.GetAxis("Horizontal");
        if(horizontal > 0.1f)
        {
            //move Right
            rb.AddForce(Vector3.right * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }

        if(horizontal < -0.1f)
        {
            //move left
            rb.AddForce(Vector3.left * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
        }
        

    }
}
