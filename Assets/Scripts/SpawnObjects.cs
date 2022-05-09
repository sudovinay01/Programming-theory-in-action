using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{

    private float spawnPosZ = 5.5f,
        spawnRangeX = 10,
        startDelay = 0,
        spawnInterval = 1f;

    [SerializeField] private List<GameObject> characters;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCharacters", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCharacters()
    {
        SpawnCharactersLeft();
        SpawnCharactersRight();
    }

    void SpawnCharactersLeft()
    {
        int randomIndex = Random.Range(0, characters.Count);
        Vector3 spawnpos = new Vector3(-spawnRangeX, 1, Random.Range(-spawnPosZ, spawnPosZ));
        Vector3 rotation = new Vector3(0, 90, 0);

        Instantiate(characters[randomIndex], spawnpos, Quaternion.Euler(rotation));
    }

    void SpawnCharactersRight()
    {
        int randomIndex = Random.Range(0, characters.Count);
        Vector3 spawnpos = new Vector3(spawnRangeX, 1, Random.Range(-spawnPosZ, spawnPosZ));
        Vector3 rotation = new Vector3(0, -90, 0);

        Instantiate(characters[randomIndex], spawnpos, Quaternion.Euler(rotation));
    }
}
