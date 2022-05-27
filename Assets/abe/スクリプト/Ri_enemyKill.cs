using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ri_enemyKill : MonoBehaviour
{
    public int BulletSpeed = 1;
    public GameObject muzzlePoint;
    public float bulletDI;

    public void Start()
    {
        Invoke("Syatei", 3.0f);
        //bulletDI = PlayerShot.BulletDI;
    }
    public void Update()
    {

        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new(10 * BulletSpeed, 0.0f);
    }
    void Syatei() 
    {
        Destroy(this.gameObject);
    }

}
