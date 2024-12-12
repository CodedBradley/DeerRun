using UnityEngine;

public class cammove : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, 3);
    }

    
    void Update()
    {
        
    }
}
