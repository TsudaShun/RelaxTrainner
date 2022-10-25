using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Game2Director : MonoBehaviour
{
    public UnityEvent gameStart;
    public UnityEvent gameEnd;
    public static int point = 0;
    // 何回目か？
    // staticはシーンが切り替わっても使える
    public static int gameCount;

    public Text CountDown;
    public Text Math;
    public Text Enter;
    public Button AnswerButton;
    int count = 3;
    public static int SumRandom;

    void Start()
    {
        AnswerButton.interactable = false;
        point = 0;
        SumRandom = Random.Range(0, 1000000);
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
        Invoke("ClearMath", 1);
    }

    public static int Getpoint()
    {
        return point;
    }

    public void ShowMath()
    {
        CountDown.enabled = false;
        Math.text = SumRandom.ToString();
        //   gameStart.Invoke();
    }

    // アンサーボタンが押された時の処理
    public void AnswerButtonDown()
    {

        if (Math.text == Enter.text)
        {
            point += 1;
            SceneManager.LoadScene("GameTrueScene");
        }
        else
        {
            SceneManager.LoadScene("GameFalseScene");
        }
    }


    void ClearMath()
    {
        Math.enabled = false;
        AnswerButton.interactable = true;
    }
}
