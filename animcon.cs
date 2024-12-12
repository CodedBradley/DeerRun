using UnityEngine;

public class animcon : MonoBehaviour
{
    
    void Start()
    {
        GetComponent<Animator>().Play("Run");
    }

    
    void Update()
    {
        
    }
}
