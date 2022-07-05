using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject createPrefabs;
    private float spawnPosX = 2.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Vector3 GenerateSpawnPosition()
    {
        float spawnPos = Random.Range(spawnPosX, -spawnPosX);
        Vector3 randomPos = new Vector3(spawnPos , transform.position.y + 1,28.0f);
        return randomPos;
    }
    public void SpawnCreates()
    {
        Instantiate(createPrefabs, GenerateSpawnPosition(), createPrefabs.transform.rotation);
    }
}
