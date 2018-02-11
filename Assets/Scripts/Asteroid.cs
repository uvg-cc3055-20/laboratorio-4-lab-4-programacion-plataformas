//Autores:
//Kevin Macario 17369
//Raul Monzon 17014
// Clase Asteorid
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {
    Rigidbody2D rb;
    private float dropSapeed = 3f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update() {
        if (GameController.instance.dead == false) { 
            transform.Translate(Vector3.down * dropSapeed * Time.deltaTime);
            if (transform.position.y < -7)
            {
                Destroy(gameObject);
            }
        }
	}
}
