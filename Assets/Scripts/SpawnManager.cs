using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    public Transform parentGameObject;
    public GameObject GroundObject;
    public GameObject[] groundPrefabs;
    private float posZ = 20;

    private void Start()
    {
        GameManager.restartGame += ResetRoad;
    }

    void Update()
    {
        if (!GameManager.Instance.isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                SpawnRoad();
            }
        }
    }

    private void SpawnRoad()
    {
        int randomIndex = Random.Range(0, groundPrefabs.Length);
        
        if (groundPrefabs[randomIndex].name == "Ground_Road2")
        {
            posZ = posZ + 1;
        }

        GameObject temp = Instantiate(groundPrefabs[randomIndex], new Vector3(0, 0, posZ), groundPrefabs[randomIndex].transform.rotation);
        temp.transform.SetParent(parentGameObject);
    }
    
    private void ResetRoad()
    {
        foreach (Transform child in parentGameObject)
        {
            Destroy(child.gameObject);
        }

        Instantiate(GroundObject, new Vector3(0, 0, 10), Quaternion.identity);
    }
}
