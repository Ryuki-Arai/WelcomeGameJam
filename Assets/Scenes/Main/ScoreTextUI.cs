using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextUI : MonoBehaviour
{
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = ("�X�R�A" + GameManager.Instance.Score); 
    }

}
