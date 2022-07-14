using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public static int CashCount;
    public static int InternalCash;
    public TextMeshProUGUI CashCountText;

    void Update()
    {
        InternalCash = CashCount;
        CashCountText.text = CashCount.ToString();
    }
}
