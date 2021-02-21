using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslatePowerUp : MonoBehaviour
{
    [SerializeField] float speed = 5;
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * speed);
    }
}
