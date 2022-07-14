using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public SpawnManager spawnManager;
    
    void Start()
    {
       
    }
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
            GlobalCargo.CargoCount += 1;
            spawnManager.SpawnCreates();
        }
        if (Input.GetMouseButtonUp(0))
        {
            transform.position = new Vector3(0f, 5.0f, 7f);
        }
        // Debug Yapýlacak
        //if (Input.GetMouseButtonUp(0))
        //{
        //    SoundControl.controller.PlayClickSounds();
        //}
        
    }
    
}
