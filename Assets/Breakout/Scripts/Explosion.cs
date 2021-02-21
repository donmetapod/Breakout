using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    [SerializeField] AudioClip explosionSfx;
    void Start()
    {
        AudioController audicoController = FindObjectOfType<AudioController>();
        audicoController.PlaySfx(explosionSfx);
    }

   
}
