using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        var y = transform.position.y;
        var z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x,y,z), speed * Time.deltaTime);
    }
}
