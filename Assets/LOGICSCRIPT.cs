using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LOGICSCRIPT : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
            if (playerScore == 0) {
                scoreText.enabled = false;
            }
    }
    public  void Retry() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver() {
        gameOverScreen.SetActive(true);
    }
}
