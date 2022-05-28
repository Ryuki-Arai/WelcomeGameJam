using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    Rigidbody2D _rb2d = default;
    [SerializeField] int _ap;
    [SerializeField] int _hp;
    [SerializeField] int _speed;
    [SerializeField] int _score;
    public 
    Transform _pPos;
    public int vec = -1;

    // Start is called before the first frame update
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _pPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = _rb2d.velocity;
        velocity =  Vector2.left * _speed * vec;
        velocity.y = _rb2d.velocity.y;
        _rb2d.velocity = velocity;
        Action();
        if (_hp <= 0) 
        {
            GameManager.Instance.Score += _score;
            Destroy(this.gameObject); 
        }
        if (this.transform.position.y < -10)
        {
            
            Destroy(this.gameObject);
        }
    }

    public abstract void Action();

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            _hp--;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Wall") vec *= -1;
    }
}
