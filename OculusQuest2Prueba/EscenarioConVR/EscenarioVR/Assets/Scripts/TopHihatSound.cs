using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHihatSound : MonoBehaviour
{
  
    public Boolean isOpen = true;
    
    public GameObject hihat;
    AudioSource AudioHihat;
    public AudioClip hhopen;
    public AudioClip hhclose;



    void Start()
    {
       
        AudioHihat = hihat.GetComponent<AudioSource>();

    }


    private void OnCollisionEnter(Collision collision)
    {
        
        if (isOpen)
            AudioHihat.PlayOneShot(hhopen);
        else
            AudioHihat.PlayOneShot(hhclose);


    }

  
}
