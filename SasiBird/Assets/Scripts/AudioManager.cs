using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip gameMusic;
    public AudioClip buttonClickSound;
    public AudioClip flapSound;
    public AudioClip scoreSound;
    public AudioClip gameOverSound;

    public void PlayGameMusic()
    {
        audioSource.clip = gameMusic;
        audioSource.loop = true;
        audioSource.Play();
    }

    public void StopGameMusic()
    {
        audioSource.loop = false;
        audioSource.clip = null;   // removes only music
    }


    public void PlayButtonClickSound()
    {
        audioSource.PlayOneShot(buttonClickSound);
    }

    public void PlayFlapSound()
    {
        audioSource.PlayOneShot(flapSound);
    }

    public void PlayScoreSound()
    {
        audioSource.PlayOneShot(scoreSound);
    }

    public void PlayGameOverSound()
    {
        audioSource.PlayOneShot(gameOverSound);
    }
}
