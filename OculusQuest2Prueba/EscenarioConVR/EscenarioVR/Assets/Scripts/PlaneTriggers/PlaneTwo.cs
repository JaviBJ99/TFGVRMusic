using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTwo : MonoBehaviour
{
    public PlaneOne plane1;

    float TimeHit2;


    private void OnCollisionEnter(Collision collision)
    {
        if (plane1.timeHit1 != 0)
        {
            TimeHit2 = Time.time;


        }
    }
}
