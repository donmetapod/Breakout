using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioClip gameMusic;
    private void Start()
    {
        musicSource.clip = gameMusic;
        musicSource.Play();
    }
    public void PlaySfx(AudioClip clip) {
        audioSource.clip = clip;
        audioSource.PlayOneShot(clip);
    }

    public void UpdateMusicVolume(float volume) {
        musicSource.volume = volume;
    }
}
