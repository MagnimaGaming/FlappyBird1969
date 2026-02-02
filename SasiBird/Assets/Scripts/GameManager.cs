using UnityEngine;
using TMPro;
//using UnityEditor.Experimental.GraphView;

public class GameManager : MonoBehaviour
{
    private int score = 0;

    public PlayerMov player;   // your actual player script
    public TMP_Text scoreText; // TextMeshPro text
    public GameObject playButton;
    public GameObject gameOver;

    
    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = "Score: " + score;

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        PipesMov[] pipes = FindObjectsOfType<PipesMov>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

        FindObjectOfType<AudioManager>().PlayGameMusic();

    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        FindObjectOfType<AudioManager>().PlayGameOverSound();  // play first
        FindObjectOfType<AudioManager>().StopGameMusic();     // then stop music

        Pause();
    }


    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score;

        FindObjectOfType<AudioManager>().PlayScoreSound();


    }
}
