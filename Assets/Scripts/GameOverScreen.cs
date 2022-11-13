using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScreen : MonoBehaviour
{

    public TextMeshProUGUI pointsText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("MainGame");
        Time.timeScale = 1;
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    public void LeaderButton()
    {
        SceneManager.LoadScene("Leaderboard");
    }
}
