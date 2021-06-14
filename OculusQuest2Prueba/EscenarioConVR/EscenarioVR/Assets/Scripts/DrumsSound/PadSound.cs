using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadSound: MonoBehaviour
{
    public SnareSound snare;


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SoundTag")
        {
            snare.TimeHitPad = Time.deltaTime;

        }

    }
    
}
