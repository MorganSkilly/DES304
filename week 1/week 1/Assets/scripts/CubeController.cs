using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // Start is called before Start
    void Awake()
    {
        Debug.Log("Awake!");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update!");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space clicked!");
            GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.up) * 5000);
        }
    }
}
