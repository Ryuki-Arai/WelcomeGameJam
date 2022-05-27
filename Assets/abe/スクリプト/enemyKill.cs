using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyKill : MonoBehaviour
{
    public int enemyHp = 5;//âºÅAìGÇÃåpè≥Ç©ÇÁéùÇ¡ÇƒÇ≠ÇÈ
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            enemyHp -= 1;
        }
    }
    public void Start()
    {
        Invoke("Syatei", 3.0f);
        this.gameObject.SetActive(false);
    }
    public void Update()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0.0f, 0.0f, 1.0f);
        rb.AddForce(force);
        

    }
    void Syatei() 
    {
        this.gameObject.SetActive(false);
    }

}
