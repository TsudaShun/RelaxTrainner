using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckGame : MonoBehaviour
{
    public void CheckGameEnd()
    {
        Game2Director.gameCount++;

        if (Game2Director.gameCount == 3)
        {
            SceneManager.LoadScene("GameEndScene");
        }
        else
        {
            SceneManager.LoadScene("GameScene2");
        }
    }
}
