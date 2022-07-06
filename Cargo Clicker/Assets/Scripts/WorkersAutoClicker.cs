using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script should work like that: when the buy a new worker then increase the cargo count automatic.
public class WorkersAutoClicker : MonoBehaviour
{
    public bool creatingCargo = false;
    public static int cargoIncrease = 0;
    public int internalIncrease;
    public GameManager gameManager;
    public SpawnManager spawnManager;
   
    void Update()
    {
        internalIncrease = cargoIncrease;
        if (creatingCargo == false)
        {
            creatingCargo = true;
            StartCoroutine(CreateTheCreate());
        }
    }
    IEnumerator CreateTheCreate()
    {
        GameManager.cargoCount += internalIncrease;
        yield return new WaitForSeconds(1);
        gameManager.UpdateCargo();
        spawnManager.SpawnCreates();

        creatingCargo = false;
    }
}
