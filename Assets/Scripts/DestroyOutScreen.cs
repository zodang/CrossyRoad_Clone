using UnityEngine;

public class DestroyOutScreen : MonoBehaviour
{
    void Update()
    {
        if (transform.position.z < -40 )
        {
            Destroy(gameObject);
        }
        
    }
}
