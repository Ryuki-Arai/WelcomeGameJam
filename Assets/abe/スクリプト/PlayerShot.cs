using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    
    public GameObject BulletObj;
    public GameObject BulletShot;
    public bool rensyaBousi;
    public float rirod;
    public static float BulletDI;
    Rigidbody2D rb2d;

    public void Start()
    {
        rensyaBousi = true;
       
    }
    public void Update()
    {


        //メモ　弾の向きはrb2d.velocity.x > 1　で取って、弾を二個(スプリプも)つくる

        //Vector2 scale = transform.localScale;
        //if (rb2d.velocity.x > 1)
        //scale.x = 1;
        //else if (rb2d.velocity.x < -1)
        // scale.x = -1;
        //transform.localScale = scale;
        if (Input.GetButtonDown("Fire1"))
        {
            if (rensyaBousi == true )
            {
                Vector2 mballpos = BulletShot.transform.position;
                GameObject newbullet = Instantiate(BulletObj, mballpos, BulletShot.transform.rotation);
                //Vector2 dir = BulletShot.transform.forward;
                //newbullet.GetComponent<Rigidbody2D>().AddForce(dir * BulletSpeed, ForceMode.Impulse);
                //newbullet.name = BulletObj.name;
                //Destroy(newbullet, 0.8f);
                
                rensyaBousi = false;
                Invoke("rensya", rirod);
            }
           
        }
    }
    public void rensya()
    {
        rensyaBousi = true;
    }
}
