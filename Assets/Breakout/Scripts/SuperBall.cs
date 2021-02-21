using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperBall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player")) {
            Ball ball = FindObjectOfType<Ball>();
            if (ball != null) {
                ball.SuperBall = true;
            }
            //GameManager gameManager = FindObjectOfType<GameManager>();

            if (GameManager.Instance != null)
            {
                GameManager.Instance.powerUpIsActive = true;
            }
            Destroy(gameObject);
        }
    }

}
