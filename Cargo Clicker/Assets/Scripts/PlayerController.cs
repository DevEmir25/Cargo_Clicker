using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;
    public SpawnManager spawnManager;
    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(7f,7f,7f)* Time.deltaTime);
        OnTouchEvent();
    }
    public void OnTouchEvent()
    {
        Rect bounds = new Rect(0, Screen.width/2, Screen.width , Screen.height/2);

        if (Input.GetMouseButtonDown(0) && bounds.Contains(Input.mousePosition))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 8f);
            gameManager.UpdateCargo();
            spawnManager.SpawnCreates();
        }
        if (Input.GetMouseButtonUp(0))
        {
            transform.position = new Vector3(0f, 5.0f, 7f);
        }
    }
    
}
