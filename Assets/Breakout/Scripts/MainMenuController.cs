using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip buttonPressedSfx;
    [SerializeField] GameObject loadGameButton;
    void LoadGameScene() {
        SceneManager.LoadScene("Game");
    }

    public void LoadSceneWithDelay(float delay) {
        loadGameButton.SetActive(false);
        audioSource.clip = buttonPressedSfx;
        audioSource.Play();
        Invoke("LoadGameScene", delay);
    }
    public void PlaySfx() {
        audioSource.PlayOneShot(buttonPressedSfx);
    }
}
