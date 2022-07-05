using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(7f,7f,7f)* Time.deltaTime);
        OnTouchEvent();
    }
    void OnTouchEvent()
    {
        Rect bounds = new Rect(0, Screen.width/2, Screen.width , Screen.height/2);

        if (Input.GetMouseButtonDown(0) && bounds.Contains(Input.mousePosition))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 8f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            transform.position = new Vector3(0f, 0.75f, 7f);
        }
    }
}
