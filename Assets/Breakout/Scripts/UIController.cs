using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject loseScreen;
    [SerializeField] GameObject winnerScreen;
    [SerializeField] GameObject[] hearts;
    [SerializeField] Text gameTimeUI;
    [SerializeField] AudioController audioController;
    [SerializeField] AudioClip buttonPressedSfx;
    [SerializeField] AudioClip loseLifeSfx;
    [SerializeField] GameObject[] buttons;

    public void ActivateLoseScreen() {
        audioController.UpdateMusicVolume(0.5f);
        loseScreen.SetActive(true);
    }

    public void ActivateWinnerScreen() {
        audioController.UpdateMusicVolume(0.5f);
        winnerScreen.SetActive(true);
    }

    void TryAgain() {
        audioController.PlaySfx(buttonPressedSfx);
        foreach (var button in buttons) {
            button.SetActive(false);
        }
        SceneManager.LoadScene("Game");
    }

    void MainMenu() {
        audioController.PlaySfx(buttonPressedSfx);
        foreach (var button in buttons)
        {
            button.SetActive(false);
        }
        SceneManager.LoadScene("MainMenu");
    }

    public void TryAgainWithDelay(float delay) {
        Invoke("TryAgain", delay);
    }

    public void LoadMainMenuWithDelay(float delay) {
        Invoke("MainMenu", delay);
    }

    public void UpdateLives(int currentLives) {
        for (int i = 0; i < hearts.Length; i++) {
            if (i >= currentLives) {
                hearts[i].SetActive(false);
            }
        }
        audioController.PlaySfx(loseLifeSfx);
    }

    public void UpdateTime(float gameTime) {
        gameTimeUI.text = "Time: " + Mathf.Floor(gameTime);
    }
}
