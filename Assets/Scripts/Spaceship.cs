//Autores:
//Kevin Macario 17369
//Raul Monzon 17014
// Clase Spaceship

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour {

    private Rigidbody2D rb;
    private float speed = 5f;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.dead == false)
        {
            float movX = Input.acceleration.x;
            rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
            PlayerPrefs.SetFloat("puntaje", GameController.instance.tiempo);
        }


    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.instance.dead = true;
    }

}
