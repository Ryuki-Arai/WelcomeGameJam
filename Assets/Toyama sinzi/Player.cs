using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed;
    Rigidbody2D rb2d;
    public float jumpPower = 15f;
    public int Hp = 5;
    //
    public GameObject RiBulletObj;
    public GameObject LeBulletObj;
    public GameObject BulletShot;
    public bool rensyaBousi;
    public float rirod;
    public static int BulletDI;
    //
    bool jmp;
    private Animator anim = null;
    SpriteRenderer SpRdr;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        SpRdr = GetComponent<SpriteRenderer>();
        //
        rensyaBousi = true;
        //
    }

    void Update()
    {

        //以下Abe追加
        Vector2 scale = transform.localScale;
        if (rb2d.velocity.x >= 1)
        {
            SpRdr.flipX = false;    
        }


        else if (rb2d.velocity.x < -1)
        {
            SpRdr.flipX = true;
            
        }
        if (SpRdr.flipX == false)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (rensyaBousi == true)
                {
                    Vector2 mballpos = BulletShot.transform.position;
                    GameObject newbullet = Instantiate(RiBulletObj, mballpos, BulletShot.transform.rotation);
                    Invoke("rensya", rirod);
                    rensyaBousi = false;

                }

            }
        }else
        if (SpRdr.flipX == true)
        {
            if (Input.GetButtonDown("Fire1"))
            {

                if (rensyaBousi == true)
                {
                    Vector2 mballpos = BulletShot.transform.position;
                    GameObject newbullet = Instantiate(LeBulletObj, mballpos, BulletShot.transform.rotation);
                    Invoke("rensya", rirod);
                    rensyaBousi = false;

                }
            }

        }



        //ここまで



        if (Input.GetButtonDown("Jump") && jmp)
        {
            rb2d.AddForce(Vector2.up * jumpPower,ForceMode2D.Impulse);
            Debug.Log("aaaaa");
        }
       
        float h = Input.GetAxis("Horizontal");

        Vector2 a = new Vector2(h,0);
        Vector2 b = a.normalized * speed;
        b.y = rb2d.velocity.y;
        rb2d.velocity = b;

        if(Hp <=0)
        {
            SceneManager.LoadScene("Result");
        }
    
    }

    private void LateUpdate()
    {
        if(anim)
        {
            Vector2 speed = rb2d.velocity;
            speed.y = 0;
            anim.SetFloat("Speed", speed.magnitude);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        jmp = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        jmp = false;
    }

    public void Damege()
    {
        Hp -= 1;
    }
    //
    public void rensya()
    {
        rensyaBousi = true;
    }


}
