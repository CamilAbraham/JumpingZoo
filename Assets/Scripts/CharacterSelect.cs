using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour {
    private int Selectindex;
    // Use this for initialization
    private SpriteRenderer spriteR;
    private Sprite[] sprites;
    private string nombre;
    private string caso;
    private Text texto;
    private Button boton;
    private Color colorO;

    // Use this for initialization
    void Start()
    {

        spriteR = GetComponent<SpriteRenderer>();

        sprites = Resources.LoadAll<Sprite>("Sprites");
        texto = GameObject.Find("Texto").GetComponent<Text>();
        boton = GameObject.Find("Select").GetComponent<Button>();
        //sprites = Resources.Load("Sprites/Oso") as Sprite;

        if (PlayerPrefs.HasKey("Personaje"))
            nombre = PlayerPrefs.GetString("Personaje");
        //pre = Resources.Load(PlayerPrefs.GetString("Personaje")) as GameObject;
        else
            nombre = "Oso";
        for (int i = 0; i < sprites.Length; i++)
        {
            if (sprites[i].name == nombre)
            {
                Selectindex = i;
                break;
            }
        }
        colorO = spriteR.material.GetColor("_Color");
    }

    private void OnGUI()
    {
        caso = sprites[Selectindex].name;
        switch (caso)
        {
            case "Oso":
                spriteR.sprite = sprites[Selectindex];
                spriteR.transform.localScale = new Vector2(70, 70);
                texto.enabled = false;
                boton.interactable = true;
                spriteR.material.SetColor("_Color", colorO);
                break;
            case "Cara":
                if (PlayerPrefs.GetInt("highscore")<1000)
                {
                    spriteR.sprite = sprites[Selectindex];
                    spriteR.transform.localScale = new Vector2(70, 70);
                    spriteR.material.SetColor("_Color", Color.black);
                    //spriteR.color = Color.black;
                    texto.text = "You need 1000 points\nto unlock";
                    texto.enabled = true;
                    boton.interactable = false;
                }
                else
                {
                    spriteR.sprite = sprites[Selectindex];
                    spriteR.transform.localScale = new Vector2(70, 70);
                    texto.enabled=false;
                    boton.interactable = true;
                    spriteR.material.SetColor("_Color", colorO);
                }
                break;
            case "Mono":
                if (PlayerPrefs.GetInt("highscore") < 10000)
                {
                    spriteR.sprite = sprites[Selectindex];
                    spriteR.transform.localScale = new Vector2(70, 70);
                    spriteR.material.SetColor("_Color", Color.black);
                    //spriteR.color = Color.black;
                    texto.text = "You need 10000 points\nto unlock";
                    texto.enabled = true;
                    boton.interactable = false;
                }
                else
                {
                    spriteR.sprite = sprites[Selectindex];
                    spriteR.transform.localScale = new Vector2(70, 70);
                    texto.enabled = false;
                    boton.interactable = true;
                    spriteR.material.SetColor("_Color", colorO);
                }
                break;
            case "Cerdo":
                if (PlayerPrefs.GetInt("highscore") < 5000)
                {
                    spriteR.sprite = sprites[Selectindex];
                    spriteR.transform.localScale = new Vector2(70, 70);
                    spriteR.material.SetColor("_Color", Color.black);
                    //spriteR.color = Color.black;
                    texto.text = "You need 5000 points\nto unlock";
                    texto.enabled = true;
                    boton.interactable = false;
                }
                else
                {
                    spriteR.sprite = sprites[Selectindex];
                    spriteR.transform.localScale = new Vector2(70, 70);
                    texto.enabled = false;
                    boton.interactable = true;
                    spriteR.material.SetColor("_Color", colorO);
                }
                break;
        }
    }

    // Update is called once per frame
    void Update () {
        OnGUI();
    }

    public void SelectLeft()
    {
        Selectindex -= 1;
        if (Selectindex < 0)
        {
            Selectindex = sprites.Length-1;
        }
    }

    public void SelectRight()
    {
        Selectindex += 1;
        if (Selectindex >= sprites.Length)
        {
            Selectindex = 0;
        }
    }

    public void Select()
    {
        PlayerPrefs.SetString("Personaje", sprites[Selectindex].name);
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
}
