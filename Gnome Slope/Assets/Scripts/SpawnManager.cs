using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float spawnPositionX = 20;
    private float spawnPositionZ = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", 2f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This method spawns random enemy from the list of enemy Prefabs on random position, facing Player
    void SpawnRandomEnemy()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnPositionX, spawnPositionX), 0.6f, spawnPositionZ);
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], spawnPosition, enemyPrefabs[enemyIndex].transform.rotation);
    }
}

