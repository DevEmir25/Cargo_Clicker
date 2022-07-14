using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuchaseLog : MonoBehaviour
{
    public GameObject AutoCargo;
    public AudioSource buyWorkerSound;
    public void StartAutoCargo()
    {
        buyWorkerSound.Play();
        AutoCargo.SetActive(true);
        GlobalCash.CashCount -= GlobalWorker.workerValue;
        GlobalWorker.workerValue *= 2;
        GlobalWorker.turnOfButton = true;
        GlobalWorker.cargoPerSec += 1;
        GlobalWorker.numberOfWorkers += 1;
    }
}
