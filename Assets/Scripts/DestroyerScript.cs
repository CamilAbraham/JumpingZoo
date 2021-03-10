using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyerScript : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Cara")
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
        else
        {
            if (collision.gameObject.transform.parent)
            {
                Destroy(collision.gameObject.transform.parent.gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
