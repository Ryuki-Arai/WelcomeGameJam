using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject gameCliar;
    //public GameObject gameCliar;
    public void Start()
    {
        if (Player.GameCliar ==false )
        {
            gameOver.SetActive(true);
            gameCliar.SetActive(false);
        }
        
        
            
        
        
            
    }
}
