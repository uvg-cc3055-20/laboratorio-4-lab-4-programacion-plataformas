//Autores:
//Kevin Macario 17369
//Raul Monzon 17014
// Clase AsteroidSpeed

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {

    public GameObject asteroid;
    public float spawnTime = 0.001f;
    public float elapsedTime = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.dead == false) { 
            if (elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-2f, 2f);
                float random2 = Random.Range(-2f, 2f);
                Instantiate(asteroid, new Vector3(random, 7, 0), Quaternion.identity);
                Instantiate(asteroid, new Vector3(random2, 7, 0), Quaternion.identity);
                elapsedTime = 0;
            }
        }

    }
}
