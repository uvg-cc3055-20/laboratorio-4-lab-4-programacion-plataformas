//Autores:
//Kevin Macario 17369
//Raul Monzon 17014
// Clase LoadOnClick

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick: MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Principal Scene");
    }
}