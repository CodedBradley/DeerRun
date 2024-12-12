using System.Collections;
using UnityEngine;

public class running : MonoBehaviour
{
    private string laneChange = "n";
    private string midJump = "n";
    void Start()
    {
        GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, 3);
    }

    
    void Update()
    {
        if (Input.GetKey("a") && (laneChange == "n") && (transform.position.x >-.9) && (midJump == "n"))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(-1, 0, 3);
            laneChange = "y";
            StartCoroutine(stopLaneChange());
        }
        if (Input.GetKey("d") && (laneChange == "n") && (transform.position.x < .9) && (midJump == "n"))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(1, 0, 3);
            laneChange = "y";
            StartCoroutine(stopLaneChange());
        }
        if (Input.GetKey("space") && (midJump == "n") && (laneChange == "n"))
        {
            GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 2, 0);
            midJump = "y";
            StartCoroutine(stopJump());
        }
    }

    IEnumerator stopJump()
    {
        yield return new WaitForSeconds(.75f);
        GetComponent<Rigidbody>().linearVelocity = new Vector3(0, -2, 3);
        yield return new WaitForSeconds(.75f);
        GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, 3);
        midJump = "n";
    }
    
    IEnumerator stopLaneChange()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody>().linearVelocity = new Vector3(0, 0, 3);
        laneChange = "n";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "obstacle")
        {
            Debug.Log("you fuckin suck mate");
        }
    }
}
