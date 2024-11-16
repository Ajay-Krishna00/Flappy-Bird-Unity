using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int playerscore;
    public Text scoreboard;
    private int high_score=0;
    public Text highscorevalue;
    public GameObject gameoverscreen;
    public AudioSource gameoverSFX;
    private bool played = false;


    public void Start()
    {
        high_score = PlayerPrefs.GetInt("Highscore", 0);
        highscorevalue.text = high_score.ToString();
    }
    public void addScore()      //[ContextMenu("increase the score")]
    {
        playerscore++;
        scoreboard.text=playerscore.ToString();
        
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover()
    {
        gameoverscreen.SetActive(true);
        if (played == false) 
        { 
            gameoverSFX.Play();
            played = true; 
        }
    }
    public void highscore()
    {
        if (playerscore > high_score)
        {
            high_score = playerscore;
            highscorevalue.text=high_score.ToString();

            PlayerPrefs.SetInt("Highscore",high_score);
            PlayerPrefs.Save();
        }
    }
    
}
