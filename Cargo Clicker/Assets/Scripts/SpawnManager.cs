using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instante;
    public Transform[] spawnPointList;
    public GameObject createPrefabs;
    private float spawnPosX = 2.5f;
    private float yPosition;
    public Transform SpawnPoint;
    private void Awake()
    {
        Instante = this;
    }
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
        Vector3 randomPos = new Vector3(spawnPos , transform.position.y,11.0f);
        return randomPos;
    }
    int point = 0;
    public void SpawnCreates()
    {

        Vector3 posY = new Vector3(spawnPointList[point].position.x, spawnPointList[point].position.y + yPosition, spawnPointList[point].position.z);
        Instantiate(createPrefabs, posY, Quaternion.identity);
        point++;
        if (point >= spawnPointList.Length)
        {
            yPosition += 0.3f;
            point = 0; 
        }
    }
}
