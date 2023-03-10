using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveDistance = 2;
    public float boundary = 10.0f;
    private float horizontalInput;
    private float verticalInput;

    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Boundary();

    }

    //Move the player
    void Move()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) | Input.GetKeyDown(KeyCode.DownArrow) | Input.GetKeyDown(KeyCode.LeftArrow) | Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                return;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.eulerAngles = new Vector3(0, -90, 0);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.eulerAngles = new Vector3(0, 90, 0);
            }
            transform.Translate(Vector3.forward * moveDistance);
        }
    }

    //Add boundary
    void Boundary()
    {
        if (transform.position.x <= -boundary)
        {
            transform.position = new Vector3(-boundary, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= boundary)
        {
            transform.position = new Vector3(boundary, transform.position.y, transform.position.z);
        }
    }
}
