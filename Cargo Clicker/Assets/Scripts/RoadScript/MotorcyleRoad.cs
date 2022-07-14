using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MotorcyleRoad : MonoBehaviour
{
    public GameObject motorcycleRoad;
    [SerializeField] private Button addButton;
    void Start()
    {
        addButton.onClick.AddListener(AddRoad);
    }

    void Update()
    {
        
    }
    public void AddRoad()
    {
        motorcycleRoad.SetActive(true);
        addButton.gameObject.SetActive(false);
    }
}
