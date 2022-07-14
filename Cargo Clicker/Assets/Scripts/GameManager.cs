using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instante;
    public static int maxCargo = 5;

    private void Awake()
    {
        Instante = this;
    }
    void Start()
    {

    }

    void Update()
    {

    }
    
}
