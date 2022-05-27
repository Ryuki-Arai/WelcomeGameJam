using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject BulletObj;

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject obj = (GameObject)Resources.Load("Bullet");
            Instantiate(obj, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
        }
    }
}
