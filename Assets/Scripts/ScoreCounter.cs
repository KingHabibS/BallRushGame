using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCounter: MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public TextMeshProUGUI MyScoreText;
    public TextMeshProUGUI MyScoreText2;
    private int ScoreNum;

    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyScoreText.text = "  " + ScoreNum;
        MyScoreText2.text = "Points: " + ScoreNum;
    }

    private void OnTriggerEnter2D(Collider2D Enemy) 
    {
        if (Enemy.tag == "Enemy")
        {
            ScoreNum += 1;
            MyScoreText.text = "  " + ScoreNum;
            MyScoreText2.text = "Points: " + ScoreNum;
            
        }
    }

    public void GameOver()
    {
        GameOverScreen.Setup(ScoreNum);
    }

}