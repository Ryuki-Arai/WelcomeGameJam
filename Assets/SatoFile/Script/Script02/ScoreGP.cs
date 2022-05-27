using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGP : MonoBehaviour
{
    public Text Scoretext;
    private int score = 0;
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            score += 10;
            Scoretext.text = string.Format("score{0}", GameManager.Instance.Score);
        }
    }
}
