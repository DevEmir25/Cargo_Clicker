using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script should work like that: when the buy a new worker then increase the cargo count automatic.
public class WorkersAutoClicker : MonoBehaviour
{
    public bool creatingCargo = false;
    public static int cargoIncrease = 1;
    public int InternalIncrease;
    public SpawnManager spawnManager;
   
    void Update()
    {
        InternalIncrease = cargoIncrease;
        if (creatingCargo == false)
        {
            creatingCargo = true;
            StartCoroutine(CreateTheCreate());
        }
    }
    IEnumerator CreateTheCreate()
    {
        GlobalCargo.CargoCount += GlobalWorker.numberOfWorkers;
        yield return new WaitForSeconds(1);
        for (int i = 0; i < GlobalWorker.numberOfWorkers; i++)
        {
            spawnManager.SpawnCreates();
        }
        creatingCargo = false;
    }

}
