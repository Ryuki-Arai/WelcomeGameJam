using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setTest : MonoBehaviour
{
    public GameObject asobi;
    //public GameObject startBu;

    public void OnClick()
    {
        AudioSource audio = this.gameObject.GetComponent<AudioSource>();
        if (audio != null)
        {
            audio.Play();
        }
        asobi.gameObject.SetActive(true);
       // startBu.gameObject.SetActive(false);
    }
}