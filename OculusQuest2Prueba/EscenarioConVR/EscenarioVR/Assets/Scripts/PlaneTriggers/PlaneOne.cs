using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneOne : MonoBehaviour
{
    public float timeHit1;

    bool isColliding = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isColliding)
        {
            timeHit1 = Time.time;
            isColliding = true;
        }
       

    }
    private void OnTriggerExit(Collider other)
    {
        isColliding = false;
    }
}
