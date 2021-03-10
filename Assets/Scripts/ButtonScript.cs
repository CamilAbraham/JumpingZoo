using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour {
    public GameObject pre;
    public int pref;
    private SpriteRenderer spriteR;
    private Sprite[] sprites;
    private string nombre;
    private int aux;
    // Use this for initialization
    void Update() {

        spriteR = GetComponent<SpriteRenderer>();

        sprites = Resources.LoadAll<Sprite>("Sprites");
        //sprites = Resources.Load("Sprites/Oso") as Sprite;

        if (PlayerPrefs.HasKey("Personaje"))
            nombre = PlayerPrefs.GetString("Personaje");
        //pre = Resources.Load(PlayerPrefs.GetString("Personaje")) as GameObject;
        else
            nombre = "Oso";
        for(int i = 0; i< sprites.Length; i++)
        {
            if(sprites[i].name == nombre)
            {
                aux = i;
                break;
            }
        }
    }

    private void OnGUI()
    {
        spriteR.sprite = sprites[aux];
        spriteR.transform.localScale = new Vector2(70,70);
    }

}
