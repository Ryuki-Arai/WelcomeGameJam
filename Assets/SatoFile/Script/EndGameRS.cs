using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameRS : MonoBehaviour
{
    //�Q�[���I��:�{�^������Ăяo��
    public void OnClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
    Application.Quit();//�Q�[���v���C�I��
#endif
    }
}
