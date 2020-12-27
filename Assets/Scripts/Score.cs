using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour {

    public float score;
    public float highscore;
    public Text recent_score;   
    // Use this for initialization
    void Start () {
       
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "GameOver")
        {
            float score = PlayerPrefs.GetFloat("Score");
            float highscore = PlayerPrefs.GetFloat("High Score");
            Debug.Log(score);
            recent_score.text = "Time: " + score + Environment.NewLine + "Best Score: " + highscore ;
            PlayerPrefs.SetFloat("Score",0);
        }
        
    }
	
}
