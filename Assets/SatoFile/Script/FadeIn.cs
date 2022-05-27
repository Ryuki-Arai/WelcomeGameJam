using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour
{
    AudioSource audioSource;
    public bool IsFade;
    public double FadeInSeconds = 1.0;
    bool IsFadeIn = true;
    double FadeDeltaTime = 0;

    void Start()
    {
        audioSource = GetComponent & lt; AudioSource & gt; ();
    }

    void Update()
    {
        if (IsFadeIn)
        {
            FadeDeltaTime += Time.deltaTime;
            if (FadeDeltaTime & gt;= FadeInSeconds)
            {
                FadeDeltaTime = FadeInSeconds;
                IsFadeIn = false;
            }
            audioSource.volume = (float)(FadeDeltaTime / FadeInSeconds);
        }
    }
}
