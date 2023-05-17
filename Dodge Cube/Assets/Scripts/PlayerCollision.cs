using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            FindObjectOfType<PlayerMovement>().enabled = false;
            FindObjectOfType<ScenesManager>().EndGame();
        }
    }
}
