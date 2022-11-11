using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game2TotalPoint : MonoBehaviour
{
    // Start is called before the first frame updatext
    public Text PointText;
    int point;

    void Start()
    {
        point = Game2Director.Getpoint();
        PointText.text =  Game2Director.gameCount.ToString() + "問中" + point.ToString() + "問正解";
        Game2Director.point = 0;
        Game2Director.gameCount = 0;
    }
}
