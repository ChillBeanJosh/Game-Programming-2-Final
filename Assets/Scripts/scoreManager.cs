using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public static scoreManager instance;

    public Text scoreText;
    public Text highscoreText;

    public int score = 0;
    public int highscore = 0;

    public bool hit = false;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Kills: " + score.ToString();
        highscoreText.text = "HighScore: " + highscore.ToString();
    }

    public void AddPoint()
    {
        hit = true;

        score += 1;
        scoreText.text = "Kills: " + score.ToString();


        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }

    }

    void Update()
    {
        if(hit == true)
        {
            hit = false;
        }
    }



  
}
