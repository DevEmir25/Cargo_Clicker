using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanRoad : MonoBehaviour
{
    public GameObject humanRoad;
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
        humanRoad.SetActive(true);
        addButton.gameObject.SetActive(false);
    }
}
