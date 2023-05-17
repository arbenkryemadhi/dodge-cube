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
        rb.AddForce(new Vector3(0, 0, -(Mathf.Log(Time.timeSinceLevelLoad + 2, 1.1f) + speed)), ForceMode.Impulse);
        Debug.Log(-(Mathf.Log(Time.timeSinceLevelLoad, 1.1f) + speed));
        Destroy(gameObject, 5f);
    }
}
