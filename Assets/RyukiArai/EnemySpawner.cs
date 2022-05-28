using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject[] enemys;
    [SerializeField] Transform spawnPoint;
    [SerializeField] int spawnTime;
    float time = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > spawnTime)
        {
            time = 0;
            Instantiate(enemys[Random.Range(0, enemys.Length - 1)], spawnPoint.position, transform.rotation);
        }
    }
}
