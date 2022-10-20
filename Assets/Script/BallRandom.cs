using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallRandom : MonoBehaviour
{
    public GameObject[] balls;
    GameObject director;


    // プレイヤーの状態(p200記載）（ゲームが実行中の時、終わった時）
    enum State
    {
        WaitStart,
        Running,
        GameEnd,
    }

    // プレイヤーの状態の初期をランニングにします（ランニングはゲームが実行中の状態）
    State playerState = State.WaitStart;

    void Start()
    {
        // 0から8までの9つの乱数を発生
        int startrandom = Random.Range(0, 9);

        balls[startrandom].GetComponent<MeshRenderer>().material.color = Color.red;

        this.director = GameObject.Find("GameDirector");


    }



    // Update is called once per frame

    void Update()
    {
        //　もし、ゲームが終了ならば、Update()メソッドは実行されない
        if (playerState == State.GameEnd)
        {
            return;
        }

        if (playerState==State.WaitStart)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform.GetComponent<MeshRenderer>().material.color == Color.red)
                {
                    int startrandom = Random.Range(0, 9);

                    hit.transform.GetComponent<MeshRenderer>().material.color = Color.white;

                    balls[startrandom].GetComponent<MeshRenderer>().material.color = Color.red;

                    this.director.GetComponent<GameDirector>().GetBall();

                }
            }
        }
    }
    // カウントダウンが終わった時に呼び出されるイベント
    public void GameStart()
    {
        playerState = State.Running;
}
    // ゲーム終了時の呼び出されるイベントパンドラ
    public void GameEnd()
    {
        playerState = State.GameEnd;
    }

   
}