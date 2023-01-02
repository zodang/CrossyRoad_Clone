using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody playerRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) | Input.GetKeyDown(KeyCode.S) | Input.GetKeyDown(KeyCode.A) | Input.GetKeyDown(KeyCode.D))
        {
            //Move forward
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.eulerAngles = new Vector3(0,0,0);
            }
            // Move backward
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.eulerAngles = new Vector3(0,-180,0);
            }         
            //Move left   
            if (Input.GetKeyDown(KeyCode.A))
            {                
                transform.eulerAngles = new Vector3(0,-90,0);
            }
            //Move right
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.eulerAngles = new Vector3(0,90,0);
            }
            
            transform.Translate(Vector3.forward * 2);
        }


    }
}
