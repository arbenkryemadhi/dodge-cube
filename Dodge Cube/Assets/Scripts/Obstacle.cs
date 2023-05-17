using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float speed = 100f;
    [SerializeField]
    Rigidbody rb;


    void Start()
    {
        rb.AddForce(new Vector3(0, 0, -(Mathf.Log(Time.timeSinceLevelLoad + 1.1f, 1.1f) + speed)), ForceMode.Impulse);
        Destroy(gameObject, 5f);
    }
}
