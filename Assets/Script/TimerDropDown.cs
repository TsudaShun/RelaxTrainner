using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDropDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dropdown ddtmp;
        List<string> optionlist = new List<string>();

        //Optionsに表示する文字列をリストに追加
        optionlist.Add("Timer:15秒");
        optionlist.Add("Timer:30秒");
        optionlist.Add("Timer:45秒");
        optionlist.Add("Timer:60秒");

        ddtmp = GetComponent<Dropdown>();

        //一度すべてのOptionsをクリア
        ddtmp.ClearOptions();

        //リストを追加
        ddtmp.AddOptions(optionlist);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
