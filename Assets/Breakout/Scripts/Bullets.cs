using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player")) {
            Paddle paddle = FindObjectOfType<Paddle>();
            if (paddle != null) {
                paddle.BulletsActive = true;
                //GameManager gameManager = FindObjectOfType<GameManager>();

                if (GameManager.Instance != null)
                {
                    GameManager.Instance.powerUpIsActive = true;
                }
            }
            Destroy(gameObject);
        }
    }
}
