using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game2Director : MonoBehaviour
{
    GameObject pointText;

    public UnityEvent gameStart;
    public UnityEvent gameEnd;
    public static int point = 0;
    // 何回目か？
    // staticはシーンが切り替わっても使える
    public static int gameCount;

    public static int problem;

    public Text CountDown;
    public Text Math;
    public Text Enter;
    public Button AnswerButton;
    int count = 3;
    public static int SumRandom;

    // ランダム数値の桁数
    public static int Sum;

    // ランダム数値を何秒表示させるか
    public static int Timer;

    void Start()
    {
        AnswerButton.interactable = false;
        
        SumRandom = Random.Range(0, Sum);
        StartCoroutine(WaitStart());
        this.pointText = GameObject.Find("Point");
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
        Invoke("ClearMath",Timer);
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
            SceneManager.LoadScene("GameTrueScene");
            point += 1;
        }
        else
        {
            SceneManager.LoadScene("GameFalseScene");
        }
    }

    public static int Getpoint()
    {
        return point;
    }


    void ClearMath()
    {
        Math.enabled = false;
        AnswerButton.interactable = true;
    }
}
