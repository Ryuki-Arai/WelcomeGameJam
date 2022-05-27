using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // タイム表記・totalTimeは自由に変更してok
    public Text timeText;
    float totalTime = 300;
    int retime;

    void Update()
    {
        // 1秒毎にカウントを1減らす
        totalTime -= Time.deltaTime;
        retime = (int)totalTime;
        timeText.text = retime.ToString();
    }
}
