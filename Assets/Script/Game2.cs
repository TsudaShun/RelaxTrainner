using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class Game2 : MonoBehaviour
{
    GameObject director2;
    InputField inputField;

    enum State
    {
        WaitStart,
        Running,
        GameEnd,
    }
    State playerState = State.WaitStart;


    void Start()
    {
        this.director2 = GameObject.Find("Game2Director");
        inputField = GameObject.Find("InputButton").GetComponent<InputField>();

    }

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
