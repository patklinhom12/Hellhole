using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float RestartDeley = 2.0f;
    public void EndGame()
    {
        if (gameEnded == false)
        {
        gameEnded = true;
        Debug.Log("Game Over");
            Invoke("RestartGame", RestartDeley);
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
