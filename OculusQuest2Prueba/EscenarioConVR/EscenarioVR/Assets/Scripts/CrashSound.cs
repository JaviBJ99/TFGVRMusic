using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSound : MonoBehaviour
{
    
    public GameObject crash;
    AudioSource AudioCrash;
    public AudioClip csound;


    void Start()
    {
       
        AudioCrash = crash.GetComponent<AudioSource>();

    }


    private void OnCollisionEnter(Collision collision)
    {
       

        AudioCrash.PlayOneShot(csound);
    }
}
