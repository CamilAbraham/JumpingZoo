using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreScript : MonoBehaviour {
    public Text highscore;
    void OnGUI()
    {
        highscore = GameObject.Find("highscore").GetComponent<Text>();
        highscore.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highscore");
    }
 }
