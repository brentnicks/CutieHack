using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnees;
    double timer;
    public double spawnDelay;


    int randomInt;
    float Range;
    // Update is called once per frame
    void Update()
    {
        if (timer >= spawnDelay)
        {
            spawnRandom();
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    void spawnRandom()
    {
        randomInt = Random.Range(0, spawnees.Length);
        Range = Random.Range(-7.0f, 7.0f);
        Instantiate(spawnees[randomInt], new Vector3 (gameObject.transform.position.x + Range, gameObject.transform.position.y, gameObject.transform.position.z) , gameObject.transform.rotation);
    }
}
