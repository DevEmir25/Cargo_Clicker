using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GlobalCargo : MonoBehaviour
{
    public static int CargoCount;
    public static int InternalCargo;
    public TextMeshProUGUI CargoCountText;

    void Update()
    {
        InternalCargo = CargoCount;
        CargoCountText.text = CargoCount.ToString();
    }
}
