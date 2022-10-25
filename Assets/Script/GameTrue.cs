using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTrue: MonoBehaviour
{
    // Start is called before the first frame update

    public Text Math;

    private void Start()
    {
        Math.text = Game2Director.SumRandom.ToString();
    }

}
