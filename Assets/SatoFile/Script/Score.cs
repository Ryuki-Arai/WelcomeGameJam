using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text Scoretext;
    int score;

    void Start()
    {


        Scoretext.text = string.Format("Score: {0}", GameManager.Instance.Score);
    }

}
