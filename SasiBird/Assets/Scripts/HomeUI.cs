using UnityEngine;

public class HomeUI : MonoBehaviour
{
    public GameObject homePanel;
    public GameManager gameManager;
    public AudioManager audioManager;   // reference

    private void Start()
    {
        Time.timeScale = 0f;
        homePanel.SetActive(true);
    }

    public void StartGame()
    {
        audioManager.PlayButtonClickSound();  // ?? sound
        homePanel.SetActive(false);
        gameManager.Play();
    }

    public void QuitGame()
    {
        audioManager.PlayButtonClickSound();  // ?? sound
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
