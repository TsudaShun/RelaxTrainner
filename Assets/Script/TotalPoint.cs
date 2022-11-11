using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalPoint : MonoBehaviour
{
    // Start is called before the first frame update

    public Text PointText;
    int point;

    void Start()
    {
        point = GameDirector.Getpoint();
        PointText.text = "得点：" + point.ToString() + "Point";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
