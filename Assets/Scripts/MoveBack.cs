using UnityEngine;

public class MoveBack : MonoBehaviour
{
    private Player PlayerScript;

    // Start is called before the first frame update
    void Start()
    {
        PlayerScript = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.Instance.isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.back * PlayerScript.moveDistance);
            }
        }
    }
}
