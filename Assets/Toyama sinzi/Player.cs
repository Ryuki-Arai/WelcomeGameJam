using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    
    public float speed;
    Rigidbody2D rb2d;
    public float jumpPower = 15f;
    public int Hp = 2;
    public bool LifeGard = false;
    public static bool GameCliar = true; 
    //
    public SpriteRenderer SpRdr;
    public GameObject LeBulletObj;
    public GameObject RiBulletObj;
    public GameObject LeBulletShot;
    public GameObject RiBulletShot;
    public bool rensyaBousi;
    public float rirod;
    public static int BulletDI;
    public Slider _sld;
    public TextMeshProUGUI _hpText;
    Animator _anim;
    //
    bool jmp;
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _sld.GetComponent<Slider>();
        _sld.maxValue = Hp;
        _sld.value = Hp;
        _hpText.GetComponent<TextMeshProUGUI>();
        //
        rensyaBousi = true;
        //
    }
    void Update()
    {
        Debug.Log(GameManager.Instance.Score);
        if(Hp <= 0)
        {
            SceneManager.LoadScene("Result 1");
            
}
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
                    Vector2 mballpos = LeBulletShot.transform.position;
                    GameObject newbullet = Instantiate(RiBulletObj, mballpos, LeBulletShot.transform.rotation);
                    Invoke("rensya", rirod);
                    rensyaBousi = false;

                }

            }
        }
        else
        if (SpRdr.flipX == true)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (rensyaBousi == true)
                {
                    Vector2 mballpos = RiBulletShot.transform.position;
                    GameObject newbullet = Instantiate(LeBulletObj, mballpos, RiBulletShot.transform.rotation);
                    Invoke("rensya", rirod);
                    rensyaBousi = false;

                }
            }

        }
        //‚±‚±‚Ü‚Å



        if (Input.GetButtonDown("Jump") && jmp)
        {
            rb2d.AddForce(Vector2.up * jumpPower,ForceMode2D.Impulse);
        }
       
        float h = Input.GetAxis("Horizontal");

        Vector2 a = new Vector2(h,0);
        Vector2 b = a.normalized * speed;
        b.y = rb2d.velocity.y;
        rb2d.velocity = b;


        _sld.value = Hp;
        _hpText.text = "HP : " + Hp + " / " + _sld.maxValue;
    }

    private void LateUpdate()
    {
        if (_anim)
        {
            _anim.SetBool("IsGrounded", jmp);
            Vector2 walkSpeed = rb2d.velocity;
            walkSpeed.y = 0;
            _anim.SetFloat("Speed", walkSpeed.magnitude);
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

   
    //
    public void rensya()
    {
        rensyaBousi = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")//LifeGard == false
        {
            Hp--;
            if (Hp <= 0)
            {
                SceneManager.LoadScene("Result 1");
                GameCliar = false;
                
            }
        }
    }
}
