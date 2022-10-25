using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameFalse : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Math;

    void Start()
    {
        Math.text = "正解："　+ Game2Director.SumRandom.ToString();

    }
}
