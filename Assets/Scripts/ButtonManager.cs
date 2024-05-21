using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // ����� ��� ������ �� ����������
    public void ExitGame()
    {
        Application.Quit();
    }

    public void GoHome()
    {
        SceneManager.LoadScene("Start Scene");
    }

    // ����� ��� ����������� ������
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}