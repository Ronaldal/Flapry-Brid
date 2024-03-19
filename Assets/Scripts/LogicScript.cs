using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playScore;
    public Text scoreText;
    public GameObject gameOver;
    public AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();

    }
    [ContextMenu("Increace score")]
    public void addScore(int scoreToAdd)
    {
        playScore = playScore + scoreToAdd;
        scoreText.text = playScore.ToString();
        audio.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOverFunc()
    {
        gameOver.SetActive(true);
    }
    public bool isGameOverActive()
    {
        return gameOver.activeSelf;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
