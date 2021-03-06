using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterwal = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterwal);   
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

            Vector3 rotation = new Vector3(0, 90, 0);

            spawnPos = new Vector3(-spawnRangeX, 0, Random.Range(0, 16));
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));

            rotation = new Vector3(0, -90, 0);

            spawnPos = new Vector3(spawnRangeX, 0, Random.Range(0, 16));
            Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));

    }
}
