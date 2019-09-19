using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControllerScript : MonoBehaviour
{
    private int Score;
    private GameObject scoreText;

    void Start()
    {
        Score = 0;
        scoreText = GameObject.Find("Score");
    }

    public void AddPoint()
    {
        Score++;
        SetScoreText();
    }

    public void ResetScore()
    {
        Score = 0;
        SetScoreText();
    }

    public int GetScore()
    {
        return Score;
    }

    private void SetScoreText()
    {
        scoreText.GetComponent<Text>().text = Score.ToString();
    }
}
