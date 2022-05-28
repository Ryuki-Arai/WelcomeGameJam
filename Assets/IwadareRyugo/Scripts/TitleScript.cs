using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScript : MonoBehaviour
{

    public Scene _scene;

    public void OnClick()
    {
    /*    AudioSource audio = this.gameObject.GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.Play();
        }*/
        SceneManager.LoadScene("MainScine");
    }
}
