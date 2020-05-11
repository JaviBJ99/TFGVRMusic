using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane2Trigger : MonoBehaviour
{

    public PlaneTrigger plane1;

    public float TimeHit2;

    public float vol;

    public SnareSound snare;

    public float db;

    public void OnTriggerEnter (Collider other)
    {

        if (plane1.timeHit1 != 0)
        {
            TimeHit2 = Time.time;

            vol = TimeHit2 - plane1.timeHit1;
            Debug.Log("TIEMPO ENTRE PLANOS  " + vol);
            //vol = vol / 10;
            
            vol = 1 - vol;
            
            db = -20.0f * Mathf.Log10(vol);

            //vol = 1 - db;

            if (vol < 0.2f)
            {
                vol = 0.2f;
            }
            //Debug.Log("Plane1" + plane1.timeHit1);
            //Debug.Log("Plane2" + TimeHit2);

            Debug.Log("TRANSFORMACIÓN " + vol);

            snare.PlaySnareSound(1);

            TimeHit2 = 0;
            plane1.timeHit1 = 0;
        }



    }
}
