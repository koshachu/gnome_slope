using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public GameObject powerup;
    private float spawnPositionX = 20;
    private float spawnPositionZ = 20;
        
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", 2f, 1.5f);
        InvokeRepeating("SpawnPowerup", 5f, 3);
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

    void SpawnPowerup()
    {
        Vector3 spawnposPowerup = new Vector3(Random.Range(-15f, 15f), 0f, Random.Range(-7f, 7f));
        Instantiate(powerup, spawnposPowerup, powerup.gameObject.transform.rotation);

    }
}

