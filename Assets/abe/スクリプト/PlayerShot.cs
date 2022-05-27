using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    
    public GameObject BulletObj;
    public GameObject BulletShot;
    public bool rensyaBousi;
    public float rirod;
    
   
    public void Start()
    {
        rensyaBousi = true;
       
    }
    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (rensyaBousi == true )
            {
                Vector2 mballpos = BulletShot.transform.position;
                GameObject newbullet = Instantiate(BulletObj, mballpos, BulletShot.transform.rotation);
                Vector2 dir = BulletShot.transform.forward;

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
