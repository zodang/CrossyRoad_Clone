using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) | Input.GetKeyDown(KeyCode.DownArrow) | Input.GetKeyDown(KeyCode.LeftArrow) | Input.GetKeyDown(KeyCode.RightArrow))
        {
            //Move forward
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.eulerAngles = new Vector3(0,0,0);
            }
            // Move backward
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.eulerAngles = new Vector3(0,-180,0);
            }         
            //Move left   
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {                
                transform.eulerAngles = new Vector3(0,-90,0);
            }
            //Move right
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.eulerAngles = new Vector3(0,90,0);
            }
            
            transform.Translate(Vector3.forward * 2);
        }
    }
}
