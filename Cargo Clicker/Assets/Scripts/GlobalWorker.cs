using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalWorker : MonoBehaviour
{
    public Button realButton;
    public TextMeshProUGUI realText;
    public int currentCash;
    public static int workerValue = 10;
    public static bool turnOfButton = false;
    public TextMeshProUGUI workerText;
    public static int numberOfWorkers;
    public static int cargoPerSec;

    
    void Update()
    {
        workerText.text = "Kargocu : " + numberOfWorkers + "\nSaniyede Kargo Sayýsý : " + cargoPerSec;
        currentCash = GlobalCash.CashCount;
        realText.text = "Isci Al - $" + workerValue;
        if (currentCash >= workerValue)
        {
            realButton.interactable = true;
        }
       else if (currentCash < workerValue)
        {
            realButton.interactable = false;
            turnOfButton = false;
        }
    }
}
