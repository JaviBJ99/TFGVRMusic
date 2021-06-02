using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideBellSound : MonoBehaviour
{

    
  
    public GameObject ride;
    AudioSource AudioBell;
    public AudioClip bsound;


    void Start()
    {
       
        AudioBell = ride.GetComponent<AudioSource>();

    }



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SoundTag")
        {
            AudioBell.PlayOneShot(bsound);
        }

    }
   
}
