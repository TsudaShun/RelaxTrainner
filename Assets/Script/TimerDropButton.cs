using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDropButton : MonoBehaviour
{
    // Start is called before the first frame update
    private AndroidJavaObject _javaClass = null;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        Dropdown ddtmp;
        List<string> optionlist = new List<string>();

        //Optionsに表示する文字列をリストに追加
        optionlist.Add("Timer:15秒");
        optionlist.Add("Timer:30秒");
        optionlist.Add("Timer:45秒");
        optionlist.Add("Timer:60秒");

        //「Dropdown」というGameObjectのDropDownコンポーネントを操作するために取得
        ddtmp = GameObject.Find("TimerDropdown").GetComponent<Dropdown>();

        //一度すべてのOptionsをクリア
        ddtmp.ClearOptions();

        //リストを追加
        ddtmp.AddOptions(optionlist);
    }
}
