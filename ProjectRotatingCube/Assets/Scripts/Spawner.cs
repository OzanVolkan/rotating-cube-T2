using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] collectables;

    float ranX;
    float ranY;
    float ranZ;

    Vector3 spawPoint;

    public float spawnRate = 1f;
    public float nextSpawn = 1f;

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            ranX = Random.Range(-49f, 49f);
            ranY = -4.5f;
            ranZ = Random.Range(1f, 99f);

            spawPoint = new Vector3(ranX, ranY, ranZ);

            Instantiate(collectables[Random.Range(0, 3)], spawPoint, Quaternion.identity);
        }
    }
}
