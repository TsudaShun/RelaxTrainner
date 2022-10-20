using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    //  任意のSceneをUnityで入力する

    public string SceneName;  

    void Start()
    {
        var button = GetComponent<Button>();

        button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(SceneName);
        });
    }
}