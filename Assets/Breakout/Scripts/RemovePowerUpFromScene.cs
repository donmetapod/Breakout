using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePowerUpFromScene : MonoBehaviour
{
    bool isQuitting;
    GameManager gameManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); ;
    }
    private void OnApplicationQuit()
    {
        isQuitting = true;
    }
    private void OnDestroy()
    {
        if (isQuitting) {
            return;
        }
        
        if (gameManager != null)
        {
            if (gameManager.powerUpOnscene)
            {
                gameManager.powerUpOnscene = false;
            }
        }
    }
}
