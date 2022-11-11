using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game2ProblemLevel : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Dropdown ProblemDropdown;

    // Update is called once per frame
    void Update()
    {
        if (ProblemDropdown.value == 0)
        {
            Debug.Log("問題数：３問");
            Game2Director.problem = 3;
        }
        else if (ProblemDropdown.value == 1)
        {
            Debug.Log("問題数：５問");
            Game2Director.problem = 5;
        }
        else if (ProblemDropdown.value == 2)
        {
            Debug.Log("問題数：７問");
            Game2Director.problem = 7;
        }
        else if (ProblemDropdown.value == 3)
        {
            Debug.Log("問題数：１０問");
            Game2Director.problem = 10;
        }
    }
}
