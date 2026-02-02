using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuPanel;
    public GameManager gameManager;
    public GameObject homePanel;

    public void OpenMenu()
    {
        FindObjectOfType<AudioManager>().PlayButtonClickSound(); // ??
        pauseMenuPanel.SetActive(true);
        Time.timeScale = 0f;
        FindObjectOfType<AudioManager>().StopGameMusic();

    }

    public void ResumeGame()
    {
        FindObjectOfType<AudioManager>().PlayButtonClickSound(); // ??
        pauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
        FindObjectOfType<AudioManager>().PlayGameMusic();

    }

    public void RestartGame()
    {
        FindObjectOfType<AudioManager>().PlayButtonClickSound(); // ??
        pauseMenuPanel.SetActive(false);
        gameManager.Play();
    }

    public void GoHome()
    {
        FindObjectOfType<AudioManager>().PlayButtonClickSound();
        FindObjectOfType<AudioManager>().StopGameMusic();

        pauseMenuPanel.SetActive(false);
        homePanel.SetActive(true);
        gameManager.Pause();
    }

}
