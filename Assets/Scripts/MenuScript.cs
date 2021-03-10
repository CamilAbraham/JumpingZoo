using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Button b = gameObject.GetComponent<Button>();
        b.onClick.AddListener(delegate () { StartGame(); });
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
}
