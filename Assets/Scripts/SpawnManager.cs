using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabsSide;
    public GameObject[] animalPrefabs;
    public Transform[] spawnSides;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
                0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length); //Calls on a random animal to spawn within the array
            Instantiate(animalPrefabs[animalIndex], spawnPos,
                animalPrefabs[animalIndex].transform.rotation);
            
            int randomSide = GetRandomNumberSide();
            Instantiate(animalPrefabsSide[animalIndex], spawnSides[randomSide].position,
                animalPrefabsSide[animalIndex].transform.rotation);
        }
    }

    public int GetRandomNumberSide()
    {
        int randomNumber = Random.Range(0, spawnSides.Length);
        return randomNumber;
    }
}
