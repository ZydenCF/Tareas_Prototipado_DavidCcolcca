using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    
    public void Jugar()
    {
        SceneManager.LoadScene("Juego"); 
    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }

}
