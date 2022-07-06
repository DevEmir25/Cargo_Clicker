using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instante;
    public TextMeshProUGUI cargoCountText;
    public TextMeshProUGUI cashText;
    public static int cargoCount;
    public static int cash = 100;

    private void Awake()
    {
        Instante = this;
    }
    void Start()
    {
        StartGame();
    }

    void Update()
    {

    }
    public void UpdateCargo()
    {
        cargoCount++;
        cargoCountText.text = "Cargo Count: " + cargoCount;
    }
    public void UpdateCash()
    {
        // When delivered a cargo cash have to increase which cargo has been delivered(the code goes here)
        cashText.text = "Cash: " + cash;
    }
    public void StartGame()
    {
        UpdateCash();
    }
}
