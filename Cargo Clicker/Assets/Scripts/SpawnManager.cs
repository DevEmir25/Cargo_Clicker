using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject createPrefabs;
    public List<GameObject> Cargos = new List<GameObject>();
    private float spawnPosX = 2.0f;

    public Vector3 GenerateSpawnPosition()
    {
        float ZspawnPos = Random.Range(28, 33);
        float XspawnPos = Random.Range(spawnPosX, -spawnPosX);
        Vector3 randomPos = new Vector3(XspawnPos , transform.position.y + 1, ZspawnPos);
        return randomPos;
    }
    public void SpawnCreates()
    {
        GameObject _cargo = Instantiate(createPrefabs, GenerateSpawnPosition(), createPrefabs.transform.rotation);
        Cargos.Add(_cargo);
       
    }
}
