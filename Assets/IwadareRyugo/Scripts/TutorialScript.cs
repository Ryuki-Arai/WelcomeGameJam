using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        AudioSource audio = this.gameObject.GetComponent<AudioSource>();
        if(audio != null)
        {
            audio.Play();
        }
        SceneManager.LoadScene("Tutorial");
    }
}
