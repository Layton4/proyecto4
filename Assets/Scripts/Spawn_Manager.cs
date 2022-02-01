using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    public GameObject[] enemies_prefabs;
    public Vector3 spawnposition;
    private float lim = 11f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 5, 2);
        //InvokeRepeating("SpawnEnemy", 3, 2);

    }


    void Update()
    {
        
    }
    public Vector3 Random_spawn_position()
    {
        float randomX = Random.Range(-lim, lim);
        float randomZ = Random.Range(-lim, lim);
        return new Vector3(randomX, 2.5f, randomZ);
    }

    public void SpawnEnemy()
    {
        int enem = Random.Range(0, enemies_prefabs.Length);
        spawnposition = Random_spawn_position();
        Instantiate(enemies_prefabs[enem], spawnposition, enemies_prefabs[enem].transform.rotation);
    }


}
