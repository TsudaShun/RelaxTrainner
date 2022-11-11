using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dropdown ddtmp;
        List<string> optionlist = new List<string>();

        //Optionsに表示する文字列をリストに追加
        optionlist.Add("レベル１");
        optionlist.Add("レベル２");
        optionlist.Add("レベル３");
        optionlist.Add("レベルMAX");

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
