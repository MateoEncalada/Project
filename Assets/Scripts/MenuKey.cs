using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKey : MonoBehaviour
{
    public KeyCode playKey = KeyCode.Escape; // Tecla para iniciar el juego
    public KeyCode returnKey = KeyCode.P; // Tecla para regresar al menú
    public KeyCode quitKey = KeyCode.Q; // Tecla para salir del juego

    void Update()
    {
        if (Input.GetKeyDown(returnKey))
        {
            Play();
        }
        else if (Input.GetKeyDown(playKey))
        {
            Regresar();
        }
        else if (Input.GetKeyDown(quitKey))
        {
            QuitGame();
        }
    }

    public void Play()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void Regresar()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
