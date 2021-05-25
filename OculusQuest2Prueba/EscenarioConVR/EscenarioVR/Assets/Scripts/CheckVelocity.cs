using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVelocity : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(rb.velocity);
        
    }
}
