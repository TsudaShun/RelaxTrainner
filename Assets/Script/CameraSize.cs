using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSize : MonoBehaviour
{
    // Start is called before the first frame update

    public float Width = 9.0f;

    //最初に作った画面のheight
    public float Height = 19.5f;

    void Start()
    {

        //Debug.Log("Screen currentResolution : " + Screen.currentResolution);


        //camera.mainを変数に格納
        Camera mainCamera = Camera.main;

        //最初に作った画面のアスペクト比 
        float defaultAspect = Width / Height;

        //実際の画面のアスペクト比
        float actualAspect = (float)Screen.width / (float)Screen.height;

        //実機とunity画面の比率
        float ratio = actualAspect / defaultAspect;

        //サイズ調整
        mainCamera.orthographicSize /= ratio;

    }
}