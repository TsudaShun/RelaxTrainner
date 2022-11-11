using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game2SpeedLevel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Dropdown SpeedDropdown;

    // Update is called once per frame
    void Update()
    {
        if (SpeedDropdown.value == 0)
        {
            Debug.Log("表示速度5秒");
            Game2Director.Timer = 5;
        }
        else if (SpeedDropdown.value == 1)
        {
            Debug.Log("表示速度4秒");
            Game2Director.Timer = 4;

        }
        else if (SpeedDropdown.value == 2)
        {
            Debug.Log("表示速度3秒");
            Game2Director.Timer = 3;

        }
        else if (SpeedDropdown.value == 3)
        {
            Debug.Log("表示速度2秒");
            Game2Director.Timer = 2;
        }
        else if (SpeedDropdown.value == 4)
        {
            Debug.Log("表示速度1秒");
            Game2Director.Timer = 1;
        }
        else if (SpeedDropdown.value == 5)
        {
            Debug.Log("表示速度0.5秒");
            Game2Director.Timer = (int)0.5;
        }
    }
}
