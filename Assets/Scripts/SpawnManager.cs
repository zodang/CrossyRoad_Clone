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
            posZ++;
        }

        Instantiate(groundPrefabs[randomIndex], new Vector3(0, 0, posZ), groundPrefabs[randomIndex].transform.rotation, parentGameObject);
    }
    
    private void ResetRoad()
    {
        foreach (Transform child in parentGameObject)
        {
            Destroy(child.gameObject);
        }

        Instantiate(GroundObject, Vector3.forward * 10, Quaternion.identity);
    }
    // 1. for로 사용해보기
    // 2. 이름 변경해보기
}
