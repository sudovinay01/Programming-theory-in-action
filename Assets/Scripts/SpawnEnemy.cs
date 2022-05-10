using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    [SerializeField] private List<GameObject> enemies;

    private float startDelay = 2,
        spawnInterval = 1,
        XSpawnPos = -250,
        Ypos =1.8f;

    private int zLinesRange = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemies", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemies()
    {
        int randonEnemy = Random.Range(0,enemies.Count);
        int randonLine = Random.Range(-zLinesRange, zLinesRange);
        Vector3 spawnPos = new Vector3(XSpawnPos, Ypos, randonLine*5);
        Instantiate(enemies[randonEnemy], spawnPos, enemies[randonEnemy].transform.rotation);
    }
}
