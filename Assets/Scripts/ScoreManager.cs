using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public int scoreToNextLevel = 60;

    void Update()
    {
        if (score >= scoreToNextLevel)
        {
            LoadNextLevel();
        }
    }

    public void AddScore(int points)
    {
        score += points;
    }

    void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
