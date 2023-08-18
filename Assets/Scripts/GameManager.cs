using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject playButton;
    [SerializeField] GameObject gameOver;
    [SerializeField] Player player;

    private void Awake() {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play() {
        score = 0;
        scoreText.text = score.ToString();

        gameOver.SetActive(false);
        playButton.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++) {
            Destroy(pipes[i].gameObject);
        }
    }

    public void Pause() {
        Time.timeScale = 0;
        player.enabled = false;
    }


    public void IncreaseScore() {
        score++;
        scoreText.text = score.ToString();
        Debug.Log("scored");
    }

    public void GameOver() {
        Debug.Log("ded");
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
