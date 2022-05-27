using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyKill : MonoBehaviour
{
    public int BulletSpeed = 1;
    //public int enemyHp = 5;//âºÅAìGÇÃåpè≥Ç©ÇÁéùÇ¡ÇƒÇ≠ÇÈ
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            //enemyHp -= 1;
        }
    }
    public void Start()
    {
        Invoke("Syatei", 3.0f);
        
    }
    public void Update()
    {
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new(10f* BulletSpeed, 0.0f);
        
        

    }
    void Syatei() 
    {
        Destroy(this.gameObject);
    }

}
