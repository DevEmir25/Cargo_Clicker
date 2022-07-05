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
    public int cargoCount;
    public int cash = 100;
    void Start()
    {
        StartGame();
    }
    private void Awake()
    {
        Instante = this;
    }

    // Update is called once per frame
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
        cash++;
        cashText.text = "Cash: " + cash;
    }
    public void StartGame()
    {
        UpdateCash();
    }
}
