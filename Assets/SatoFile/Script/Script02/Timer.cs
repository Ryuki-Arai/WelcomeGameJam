using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // �^�C���\�L�EtotalTime�͎��R�ɕύX����ok
    public Text timeText;
    float totalTime = 300;
    int retime;

    void Update()
    {
        // 1�b���ɃJ�E���g��1���炷
        totalTime -= Time.deltaTime;
        retime = (int)totalTime;
        timeText.text = retime.ToString();
    }
}
