using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class GameDirector : MonoBehaviour
{
    // カウントダウンが終わった時に呼び出されるイベント
    public UnityEvent gameStart;

    // 終了時に呼び出されるイベント
    public UnityEvent gameEnd;

    public static int point = 0;


    GameObject timerText;
    GameObject pointText;
    float timer = 15.0f;
    public Text CountDown;
   // float CountText = 4f;
    int count = 3;
    int retime;

    //int point = 0;
    public void GetBall()
    {
        point += 1;
    }

    void Start()
    {
        point = 0;
        this.timerText = GameObject.Find("Timer");
        this.pointText = GameObject.Find("Point");

        //42行目〜54行目までのコードは、42行目実行後、
        StartCoroutine(WaitStart());
    }

    private IEnumerator WaitStart()
    {
        while (count > -1)
        {
            yield return new WaitForSeconds(1);
            CountDown.text = (--count).ToString();
        }
        CountDown.enabled = false;
        gameStart.Invoke();
    }

    public static int Getpoint()
    {
        return point;
    }

    // Update is called once per frame
    void Update()
    {
        //自分が書いたコードだと何回も呼び出される
        /*
        if (CountText >= 0)
        {
            CountText -= Time.deltaTime;
            count = (int)CountText;
            CountDown.text = count.ToString();
            return;
        }
        */

        if (count <= 0)
        {
            CountDown.text = "";

            this.timer -= Time.deltaTime;
            this.timerText.GetComponent<Text>().text = this.timer.ToString("F1") + "秒前";

            this.pointText.GetComponent<Text>().text = point.ToString() + "point";
            gameStart.Invoke();
        }

        // タイマーが０になるとゲーム終了
        if (timer <= 0)
        {
            this.timerText.GetComponent<Text>().text = "トレーニング終了！";

            // ゲーム終了なのでイベントを呼び出す
            gameEnd.Invoke();

            StartCoroutine(GoToGameOverCoroutine());
        }
    }

    public IEnumerator GoToGameOverCoroutine()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("GameEndScene");
    }
}
