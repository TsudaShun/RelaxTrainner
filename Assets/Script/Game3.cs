using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//　using static UnityEditor.PlayerSettings;

public class Game3 : MonoBehaviour
{
    GameObject director;
    public GameObject PrefabBall;

    // 1つ前の作られたボール
    GameObject pastBall;

    // プレイヤーの状態(p200記載）（ゲームが実行中の時、終わった時）
    enum State
    {
        WaitStart,
        Running,
        GameEnd,
    }

    State playerState = State.WaitStart;

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-10.0f, 10.0f);
        float y = Random.Range(-3.7f, 3.7f);
        Vector3 pos = new Vector3(x, y, 0f);
        pastBall = Instantiate(PrefabBall, pos, Quaternion.identity);
        this.director = GameObject.Find("Game3Director");
    }



    // Update is called once per frame
    void Update()
    {
        if (playerState == State.GameEnd)
        {
            return;
        }

        if (playerState == State.WaitStart)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            // 画面にマウス（指）が当たってる時
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                //  画面にマウス（指）が当たっていて、かつ赤色に触れている時
                if (hit.transform.GetComponent<MeshRenderer>().material.color == Color.red)
                {
                    this.director.GetComponent<Game3Director>().GetBall();

                     //　pastBall（過去のボール）の中身（変数）が入っている時
                    if (pastBall != null)
                    {
                        Destroy(pastBall);
                    }

                    float x = Random.Range(-10.0f, 10.0f);
                    float y = Random.Range(-3.7f, 3.7f);
                    Vector3 pos = new Vector3(x, y, 0f);
                    pastBall = Instantiate(PrefabBall, pos, Quaternion.identity);
                }

            }
        }
    }

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



