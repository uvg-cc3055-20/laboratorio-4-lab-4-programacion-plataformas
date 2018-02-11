//Autores:
//Kevin Macario 17369
//Raul Monzon 17014
// Clase GameController


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {
    public static GameController instance;
    public bool dead = false;
    public Text etiquetaT;
    public int puntaje = 0;
    public float tiempo = 0;

    // Use this for initialization
    void Start () {
        instance = this;
        etiquetaT.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update () {
        if (dead == false){
            tiempo += Time.deltaTime;
            etiquetaT.text = "Puntaje: " + tiempo.ToString("n2");
        }
        else{
            if (tiempo > PlayerPrefs.GetFloat("puntaje"))
            {
                PlayerPrefs.SetFloat("puntaje", GameController.instance.tiempo);
            }
            SceneManager.LoadScene("Menu");
        }

    }
}
