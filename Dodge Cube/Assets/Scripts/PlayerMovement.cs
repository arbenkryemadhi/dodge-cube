using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    public float speed = 6f;

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey("right"))
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            rb.velocity = new Vector3(-speed, 0, 0);
        }
    }
}
