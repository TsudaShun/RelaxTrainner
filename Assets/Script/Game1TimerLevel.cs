using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game1TimerLevel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Dropdown TimerDropdown;

    // Update is called once per frame
    void Update()
    {
        if (TimerDropdown.value == 0)
        {
            Debug.Log("Timer:15秒");
            GameDirector.baseTimer = 15;
        }
        else if (TimerDropdown.value == 1)
        {
            Debug.Log("Timer:30秒");
            GameDirector.baseTimer = 30;

        }
        else if (TimerDropdown.value == 2)
        {
            Debug.Log("Timer:45秒");
            GameDirector.baseTimer = 45;

        }
        else if (TimerDropdown.value == 3)
        {
            Debug.Log("Timer:60秒");
            GameDirector.baseTimer = 60;
        }
    }
}
