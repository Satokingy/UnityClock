using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class framerate : MonoBehaviour
{
    //フレームレートを設定
    void Start()
    {
        //静止画を表示する場合はtargetFrameRateを1にしておくと節電できます
        Application.targetFrameRate = 60;
    }
}
