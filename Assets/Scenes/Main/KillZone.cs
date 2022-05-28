using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
     if(collision.gameObject.tag =="Player")
        {
           Player.Hp = 0;
        }else
          if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
