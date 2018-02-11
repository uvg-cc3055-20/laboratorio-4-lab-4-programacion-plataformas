using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour {
    public Text score;

    // Use this for initialization
    void Start()
    {
        score.text = "Puntaje Maximo: " + PlayerPrefs.GetFloat("puntaje").ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
        score.text = "Puntaje Maximo: " + PlayerPrefs.GetFloat("puntaje").ToString("n2");
    }
}
