using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] GroundPrefabs;
    public GameObject[] index;
    private float posZ = 20;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int randomIndex = Random.Range(0, GroundPrefabs.Length);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            if (GroundPrefabs[randomIndex].name == "Ground_Road2")
            {
                posZ = posZ + 1;
            }

            Instantiate(GroundPrefabs[randomIndex], new Vector3(0, 0, posZ), GroundPrefabs[randomIndex].transform.rotation);

            if (GroundPrefabs[randomIndex].name == "Ground_Road2")
            {
                posZ = posZ + 1;
            }

        }

        

    }
}
