using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        //Get distance between player and camera
        distance = player.transform.position - transform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        //Camera follow the player's movement
        transform.position = player.transform.position - distance;
    }
}
