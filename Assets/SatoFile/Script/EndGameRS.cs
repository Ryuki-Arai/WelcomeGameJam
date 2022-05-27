using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameRS : MonoBehaviour
{
    //ゲーム終了:ボタンから呼び出す
    public void OnClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//ゲームプレイ終了
#else
    Application.Quit();//ゲームプレイ終了
#endif
    }
}
