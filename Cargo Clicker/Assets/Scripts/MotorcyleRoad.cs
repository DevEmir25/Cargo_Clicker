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
        addButton = GetComponent<Button>();
        addButton.onClick.AddListener(AddRoad);
        addButton.gameObject.SetActive(true);
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
