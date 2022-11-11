using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    // カウントダウンが終わった時に呼び出されるイベント
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
        if (count <= 0)
        {
            CountDown.text = "";

            timer -= Time.deltaTime;
            this.timerText.GetComponent<Text>().text = timer.ToString("F1") + "秒前";

            this.pointText.GetComponent<Text>().text = point.ToString() + "point";
            gameStart.Invoke();
        }

        // タイマーが０になるとゲーム終了
        if (timer <= 0)
        {
            this.timerText.GetComponent<Text>().text = "終了！";

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
