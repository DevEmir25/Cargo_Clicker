using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
//This script should work like that: when a specified courier has been delivered a cargo cargo count 
public class DeliveredCargo : MonoBehaviour
{
    public SpawnManager spawnManager;
    public TextMeshProUGUI outOfCargoText;
    

    public void ManCourier()
    {
        DestroyCargo(1);
    }
    public void VehicleCourier()
    {
        DestroyCargo(5);
    }
    public void TrainCourier()
    {
        DestroyCargo(10);
    }
    public void ShipCourier()
    {
        DestroyCargo(15);
    }
    void DestroyCargo(int count)
    {
        if (GlobalCargo.CargoCount >= count)
        {
            GlobalCargo.CargoCount -= count;
            GlobalCash.CashCount += count;
            for (int i = 0; i < count; i++)
            {
                Destroy(spawnManager.Cargos[0]);
                spawnManager.Cargos.RemoveAt(0);
            }
        }
        else if (GlobalCargo.CargoCount < count)
        {
            outOfCargoText.text = "Yeterli Kargo Kalmadý.";
            outOfCargoText.GetComponent<Animation>().Play("OutOfCargo");
        }
    }
}
