using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {
    public GameObject[] obj;
    public float min = 1f;
    public float max = 2f;


	// Use this for initialization
	void Start () {
        Spawn();
	}
	
	// Update is called once per frame
	void Spawn () {
        Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position+new Vector3(0f,Random.Range(-150f, 150f), 0f), Quaternion.identity);
        Invoke("Spawn", Random.Range(min, max));
	}
}
