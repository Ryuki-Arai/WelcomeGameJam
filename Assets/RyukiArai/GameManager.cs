using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                var obj = new GameObject(typeof(GameManager).Name);
                _instance = obj.AddComponent<GameManager>();
            }
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    int score;

    public int Score
    {
        get => score;
        set
        {
            score = value;
        }
    }

    public void SetZero()
    {
        score = 0;
    }
}
