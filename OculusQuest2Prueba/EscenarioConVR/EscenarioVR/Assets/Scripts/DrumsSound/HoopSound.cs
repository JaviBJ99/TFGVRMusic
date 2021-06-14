using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopSound : MonoBehaviour
{
    // Start is called before the first frame update

    public SnareSound snare;

  
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "SoundTag")
        {
            
            snare.TimeHitHoop = Time.deltaTime;
            
        }

    }
    
}
