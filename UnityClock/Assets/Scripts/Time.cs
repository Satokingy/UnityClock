using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour {

    //テキストUIをドラッグ&ドロップ
    [SerializeField] Text DateTimeText;

    //DateTimeを使うため変数を設定
    DateTime TodayNow;

    void Start()
    {	
	Invoke(nameof(Delay), 1f);
    }    

    void Delay()
    {
        //時間を取得
        TodayNow = DateTime.Now;

        //テキストUIに年・月・日・秒を表示させる
        DateTimeText.text = TodayNow.Year.ToString() + "年 " + TodayNow.Month.ToString() + "月" + TodayNow.Day.ToString() + "日 " + DateTime.Now.ToLongTimeString();
	Invoke(nameof(Delay), 1f);
    }
}
