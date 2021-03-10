using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScore : MonoBehaviour {
    public Text score;
    // Use this for initialization
    void OnGUI()
    {
        score = GameObject.Find("Texto").GetComponent<Text>();
        score.text = "SCORE: " + PlayerPrefs.GetInt("Score");
        if (PlayerPrefs.GetInt("highscore") < PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("highscore", PlayerPrefs.GetInt("Score"));
        }
    }
}
