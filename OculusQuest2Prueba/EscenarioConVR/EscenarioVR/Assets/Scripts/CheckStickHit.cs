using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckStickHit : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isCollision = false; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Drumstick" && isCollision == false)
        {
            isCollision = true;
            Debug.Log("COLISION");
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        isCollision = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        isCollision = false;
    }
}
