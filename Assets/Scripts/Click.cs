using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour {
    public GameObject mySecondCanvas;
    // Use this for initialization
    public void Start()
    {
        mySecondCanvas.SetActive(false);
    }
    public void Play(int select)
    {
        if (select==1)
            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        if (select==2)
            SceneManager.LoadScene("Personajes", LoadSceneMode.Single);
    }
    public void Restart()
    {
        mySecondCanvas.SetActive(true);
        
    }
    public void Yes()
    {
        PlayerPrefs.SetInt("highscore", 0);
        PlayerPrefs.SetString("Personaje", "Oso");
        mySecondCanvas.SetActive(false);
    }
    public void No()
    {
        mySecondCanvas.SetActive(false);
    }

}
