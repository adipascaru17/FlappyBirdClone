using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{

   public int playerScore;
   public Text scoreText;
   public GameObject gameOverScreen;
   public AudioSource audioScoring;
   public AudioSource audioGameOver;
   public AudioClip audioClipGameOver;


    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore += 1;
        scoreText.text = playerScore.ToString();
        audioScoring.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        audioGameOver.PlayOneShot(audioClipGameOver);

    }
}
