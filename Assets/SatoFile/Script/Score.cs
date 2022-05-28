using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text Scoretext;
    public GameObject clearText;
    public GameObject gameoverText;
    int score;

    void Start()
    {
        Debug.Log(Player.GameCliar);
        clearText.SetActive(Player.GameCliar);
        gameoverText.SetActive(!Player.GameCliar);

        Scoretext.text = string.Format("Score: {0}", GameManager.Instance.Score);
    }

}
