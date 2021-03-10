using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public GameObject menuPausa;
    // Use this for initialization
    void Start () {
        menuPausa.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void pausa()
    {
        Time.timeScale = 0;
        menuPausa.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
    public void continuar()
    {
        Time.timeScale = 1;
        menuPausa.SetActive(false);
    }
    public void menu()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
        Time.timeScale = 1;
    }
}
