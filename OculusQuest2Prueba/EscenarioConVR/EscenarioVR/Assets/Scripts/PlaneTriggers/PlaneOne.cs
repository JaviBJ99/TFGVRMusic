using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneOne : MonoBehaviour
{
    public float timeHit1;

    private void OnTriggerEnter(Collider other)
    {

        timeHit1 = Time.time;

    }
}
