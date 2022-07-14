using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipRoad : MonoBehaviour
{
    public GameObject shipRoad;
    [SerializeField] private Button addButton;
    void Start()
    {
        addButton.onClick.AddListener(AddRoad);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddRoad()
    {
        shipRoad.SetActive(true);
        addButton.gameObject.SetActive(false);
    }
}
