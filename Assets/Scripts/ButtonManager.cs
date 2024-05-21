using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Метод для выхода из приложения
    public void ExitGame()
    {
        Application.Quit();
    }

    public void GoHome()
    {
        SceneManager.LoadScene("Start Scene");
    }

    // Метод для перезапуска уровня
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}