using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        Vector2 a = new Vector2(h,0);
        Vector2 b = a.normalized * speed;
        rb2d.velocity = b;
    }
}
