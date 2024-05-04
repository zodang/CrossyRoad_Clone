using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveDistance = 2;
    public float boundary = 10.0f;
    private float horizontalInput;
    private float verticalInput;


    private void Start()
    {
        GameManager.restartGame += ResetPlayer;
    }

    void Update()
    {
        MovePlayer();
        CheckBoundary();
    }
    
    //Move the player
    void MovePlayer()
    {
        if (!GameManager.Instance.isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                return;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                transform.Translate(Vector3.forward * moveDistance);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.eulerAngles = new Vector3(0, -90, 0);
                transform.Translate(Vector3.forward * moveDistance);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.eulerAngles = new Vector3(0, 90, 0);
                transform.Translate(Vector3.forward * moveDistance);
            }
        }
    }

    //Add boundary
    void CheckBoundary()
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

    private void ResetPlayer()
    {
        gameObject.transform.position = Vector3.up * 0.25f;
        gameObject.transform.rotation = Quaternion.identity;
    }
}
