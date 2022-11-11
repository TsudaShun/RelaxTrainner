using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProblemDropDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dropdown ddtmp;
        List<string> optionlist = new List<string>();

        //Optionsに表示する文字列をリストに追加
        optionlist.Add("問題数：３問");
        optionlist.Add("問題数：５問");
        optionlist.Add("問題数：７問");
        optionlist.Add("問題数：１０問");

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
