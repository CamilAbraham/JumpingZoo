using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour {
    public Rigidbody2D rb;
    public Transform groundCheck;
    /*public Transform crashCheck;
    public Transform crashCheck2;
    public Transform crashCheck3;*/
    public float groundCheckRadius;
    //public float crashCheckRadius;
    public LayerMask whatIsGround;
    //public LayerMask whatIsCrash;
    private bool onGround;
    //private bool crash;
    //private bool crash2;
    //private bool crash3;
    private int cont=0;
    public float score;
    public Text scores;
    public string nombre;
    public int aux;
    private SpriteRenderer spriteR;
    private Sprite[] sprites;
    private float vel;
    // Use this for initialization
    void Start()
    {
        spriteR = GetComponent<SpriteRenderer>();
        sprites = Resources.LoadAll<Sprite>("Sprites");
        rb = GetComponent<Rigidbody2D>();
        if (PlayerPrefs.HasKey("Personaje"))
            nombre = PlayerPrefs.GetString("Personaje");
        else
            nombre = "Oso";
        for (int i = 0; i < sprites.Length; i++)
        {
            if (sprites[i].name == nombre)
            {
                aux = i;
                break;
            }
        }
        vel = 500;
    }

    // Update is called once per frame
    void Update()
    {
        vel = 500 + (((int)(PlayerPrefs.GetInt("Score") / 1000))*50);
        rb.velocity = new Vector2(vel, rb.velocity.y);
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        /*crash = Physics2D.OverlapCircle(crashCheck.position, crashCheckRadius, whatIsCrash);
        crash2 = Physics2D.OverlapCircle(crashCheck2.position, crashCheckRadius, whatIsCrash);
        crash3 = Physics2D.OverlapCircle(crashCheck3.position, crashCheckRadius, whatIsCrash);*/
        score += Time.deltaTime;
        PlayerPrefs.SetInt("Score", (int)(score*100));

        if (onGround)
        {
            cont = 0;
        }

        if (Input.GetMouseButtonDown(0) && cont<=1)
        {
            rb.velocity = new Vector2(rb.velocity.x, 600);
            cont = cont + 1;
        }
        /*if (crash || crash2 || crash3)
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }*/
    }

    private void OnGUI()
    {
        scores = GameObject.Find("Texto").GetComponent<Text>();
        scores.text = "SCORE: " + PlayerPrefs.GetInt("Score");
        spriteR.sprite = sprites[aux];
    }



}
