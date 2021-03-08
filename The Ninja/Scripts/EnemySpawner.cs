using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 3f;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-6.27f, 6.5f);
            whereToSpawn = new Vector2(randX, 6f);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
            enemynum.currentnum++;
        }

        if (Timer.currentime > 15 && Timer.currentime < 30)
        {
            spawnRate = 2f;
        }

        if (Timer.currentime > 30 && Timer.currentime < 60)
        {
            spawnRate = 1f;
        }

        if (Timer.currentime > 60)
        {
            spawnRate = 0.75f;
        }
    }
}
