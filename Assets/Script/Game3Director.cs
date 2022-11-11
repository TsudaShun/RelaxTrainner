using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game3Director : MonoBehaviour
{
    // Start is called before the first frame update

    public UnityEvent gameStart;

    // 終了時に呼び出されるイベント
    public UnityEvent gameEnd;

    public static int point = 0;


    GameObject timerText;
    GameObject pointText;
    public static float timer;
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

    // Update is called once per frame
    void Update()
    {
        if (count <= 0)
        {
            CountDown.text = "";

            timer -= Time.deltaTime;
            this.timerText.GetComponent<Text>().text = timer.ToString("F1") + "秒前";

            this.pointText.GetComponent<Text>().text = point.ToString() + "point";
            gameStart.Invoke();

            if (timer <= 0)
            {
                this.timerText.GetComponent<Text>().text = "終了！";

                // ゲーム終了なのでイベントを呼び出す
                gameEnd.Invoke();

                StartCoroutine(GoToGameOverCoroutine());
            }
        }
    }

    public static int Getpoint()
    {
        return point;
    }

    public IEnumerator GoToGameOverCoroutine()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Game3EndScene");
    }
}
