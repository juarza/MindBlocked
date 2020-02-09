using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public void cambiarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);

    }

    public void salirJuego()
    {
        Application.Quit();
    }


}