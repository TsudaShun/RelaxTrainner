using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class GameDirector : MonoBehaviour
{
    // 終了時に呼び出されるイベント
    public UnityEvent gameEnd;

    GameObject timerText;
    GameObject pointText;
    float timer = 15.0f;
    public Text CountDown;
    float CountText = 4f;
    int count;
    int retime;

    int point = 0;
    public void GetBall()
    {
        this.point += 1;
    }

    void Start()
    {
        this.timerText = GameObject.Find("Timer");
        this.pointText = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {

        if (CountText >= 0)
        {
            CountText -= Time.deltaTime;
            count = (int)CountText;
            CountDown.text = count.ToString();

        }

        if (CountText <= 0)
        {
            CountDown.text = "";

            this.timer -= Time.deltaTime;
            this.timerText.GetComponent<Text>().text = this.timer.ToString("F1") + "秒前";

            this.pointText.GetComponent<Text>().text = this.point.ToString() + "point";
        }


        // タイマーが０になるとゲーム終了
        if (timer <= 0)
        {
            this.timerText.GetComponent<Text>().text = "トレーニング終了！";

            // ゲーム終了なのでイベントを呼び出す
            gameEnd.Invoke();

        }
    }
}
