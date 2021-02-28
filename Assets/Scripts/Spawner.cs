using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawntime = 2f;

    public GameObject enemy;

    void Update()
    {
        if (spawntime <= 0)
        {
            float rand = Random.Range(-10 , 10);
            Instantiate(enemy , new Vector2(rand , transform.position.y) , new Quaternion());
            spawntime = 3;
        }
        else
        {
            spawntime -= Time.deltaTime;
        }
    }
}
