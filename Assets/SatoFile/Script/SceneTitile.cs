using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTitile : MonoBehaviour
{
    // ボタンを押した際タイトルに戻る
    public void OnClick()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
