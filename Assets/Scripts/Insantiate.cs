using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Insantiate : MonoBehaviour
{
    public GameObject pref;
    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.HasKey("Personaje"))
            pref = Resources.Load(PlayerPrefs.GetString("Personaje")) as GameObject;
        else
            pref = Resources.Load("Cara") as GameObject;

        Instantiate(pref, new Vector2(535, 298), Quaternion.identity);
        pref.transform.localScale = new Vector3(60, 60, 1);
    }
}
