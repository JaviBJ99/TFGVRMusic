using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopDetectSound : MonoBehaviour
{
    // Start is called before the first frame update

    public SnareSound snare;

    public Console console;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SoundTag")
        {

            snare.TimeHitHoop = Time.deltaTime;
            console.hoop("yes");
        }
          
        
    }
}
