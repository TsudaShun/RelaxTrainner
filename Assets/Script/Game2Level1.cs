using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game2Level1 : MonoBehaviour
{
    //Dropdownを格納する変数
    [SerializeField] private Dropdown dropdown;

    // Update is called once per frame
    void Update()
    {
        if (dropdown.value == 0)
        {
            Debug.Log("レベル１が選ばれた");
            Game2Director.Sum = 100000;
        }
        else if (dropdown.value == 1)
        {
            Debug.Log("レベル２が選ばれた");
            Game2Director.Sum = 1000000;

        }
        else if (dropdown.value == 2)
        {
            Debug.Log("レベル３が選ばれた");
            Game2Director.Sum = 10000000;
            
        }
        else if (dropdown.value == 3)
        {
            Debug.Log("レベルMAXが選ばれた");
            Game2Director.Sum = 100000000;

        }
    }
}