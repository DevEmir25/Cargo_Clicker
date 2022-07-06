using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//This script should work like that: when a specified courier has been delivered a cargo cargo count 
public class DeliveredCargo : MonoBehaviour
{
    public SpawnManager spawnManager;
    public TextMeshProUGUI textBox;
    public TextMeshProUGUI statusBox;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            CourierHuman();
        }
    }
    public void CourierHuman()
    {
        GameManager.cargoCount--;
        GameManager.Instante.cargoCountText.text = GameManager.cargoCount.ToString();
        if (GameManager.cargoCount <= 0)
        {
            GameManager.cargoCount=0;
            GameManager.Instante.cargoCountText.text = GameManager.cargoCount.ToString();
            statusBox.text = "Kargo Kalmadý";
            statusBox.GetComponent<Animation>().Play("OutOfCargo");
        }
        else
        {
            if (spawnManager.Cargos.Count >= 1)
            {
                Destroy(spawnManager.Cargos[0]);
                spawnManager.Cargos.RemoveAt(0);
            }
        }
    }
    
}
