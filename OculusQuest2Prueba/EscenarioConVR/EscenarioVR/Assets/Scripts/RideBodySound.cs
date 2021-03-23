using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideBodySound : MonoBehaviour
{
    
   
    public GameObject ride;
    AudioSource AudioRide;
    public AudioClip rsound;


    void Start()
    {
     
        AudioRide = ride.GetComponent<AudioSource>();

    }


    private void OnCollisionEnter(Collision collision)
    {
        //typeOfSound.GoliathSound();

        AudioRide.PlayOneShot(rsound);
    }
}
