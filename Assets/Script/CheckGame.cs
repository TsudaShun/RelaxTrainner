using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckGame : MonoBehaviour
{
    public void CheckGameEnd()
    {
        Game2Director.gameCount++;

        if (Game2Director.gameCount == Game2Director.problem)
        {
            SceneManager.LoadScene("Game2EndScene");
        }
        else
        {
            SceneManager.LoadScene("GameScene2");
        }
    }
}
