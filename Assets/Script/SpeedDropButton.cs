using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedDropButton : MonoBehaviour
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
        optionlist.Add("表示速度5秒");
        optionlist.Add("表示速度4秒");
        optionlist.Add("表示速度3秒");
        optionlist.Add("表示速度2秒");
        optionlist.Add("表示速度1秒");

        //「Dropdown」というGameObjectのDropDownコンポーネントを操作するために取得
        ddtmp = GameObject.Find("SpeedDropdown").GetComponent<Dropdown>();

        //一度すべてのOptionsをクリア
        ddtmp.ClearOptions();

        //リストを追加
        ddtmp.AddOptions(optionlist);
    }
}
