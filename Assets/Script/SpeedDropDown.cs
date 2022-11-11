using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedDropDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dropdown ddtmp;
        List<string> optionlist = new List<string>();

        //Optionsに表示する文字列をリストに追加
        optionlist.Add("表示速度5秒");
        optionlist.Add("表示速度4秒");
        optionlist.Add("表示速度3秒");
        optionlist.Add("表示速度2秒");
        optionlist.Add("表示速度1秒");

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
