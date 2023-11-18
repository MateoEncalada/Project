using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public KeyCode playKey = KeyCode.P; // Tecla para iniciar el juego
    public KeyCode returnKey = KeyCode.Escape; // Tecla para regresar al menú
    public KeyCode quitKey = KeyCode.Q; // Tecla para salir del juego

    void Update()
    {
        if (Input.GetKeyDown(playKey))
        {
            Play();
        }
        else if (Input.GetKeyDown(returnKey))
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
