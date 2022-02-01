using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruits : MonoBehaviour
{
    public GameObject[] spwanFruits;
    private float minPosY =  3.5f;
    private float maxPosY = 9f;
    private float rangePosX = 40f;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        // START INSTATIATIONS
        InvokeRepeating("SpawnDurianFruits", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // SPAWN FRUITS
    void SpawnDurianFruits()
    {
        // USE RANDOM
        int index = Random.Range(0, spwanFruits.Length);

        Vector3 randomPos = new Vector3(Random.Range(0, rangePosX), Random.Range(minPosY ,maxPosY), 0 ); // RANDOMIZ VECTOR EACH INSTANTITE

        // INSTANTIATE
        Instantiate(spwanFruits[index], randomPos, spwanFruits[index].transform.rotation);
    }
}
