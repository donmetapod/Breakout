using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSizePaddle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player")) {
            Paddle paddle = collision.transform.GetComponent<Paddle>();
            if (paddle != null)
            { 
                paddle.IncreaseSize();
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
