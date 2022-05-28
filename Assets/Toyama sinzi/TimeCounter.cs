using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    float Timer;

    [SerializeField]  TextMeshProUGUI timer = default;
    [SerializeField] float totalTime;
    int seconds;
    private void Start()
    {
        timer = GetComponent<TextMeshProUGUI>();
        Timer = totalTime;
    }

    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer < 0)
        {
            SceneManager.LoadScene("Result 1");
        }
        timer.text = Timer.ToString("F0");
    }
}
