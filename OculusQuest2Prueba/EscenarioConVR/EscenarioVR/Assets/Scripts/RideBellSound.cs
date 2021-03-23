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


    private void OnCollisionEnter(Collision collision)
    {
        //typeOfSound.GoliathSound();

        AudioBell.PlayOneShot(bsound);
    }
}
