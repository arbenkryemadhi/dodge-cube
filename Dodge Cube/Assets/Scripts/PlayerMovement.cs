using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed;

    void Update()
    {
        // Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0));

        //Game Over
        if (transform.position.y < -1f)
        {
            FindObjectOfType<PlayerMovement>().enabled = false;
            FindObjectOfType<ScenesManager>().EndGame();
        }
    }
}
