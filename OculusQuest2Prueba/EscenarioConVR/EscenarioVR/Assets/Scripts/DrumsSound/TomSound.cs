using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomSound : MonoBehaviour
{

    
  
    public GameObject tom;
    AudioSource AudioTom;
    public AudioClip tsound;


    void Start()
    {
       
        AudioTom = tom.GetComponent<AudioSource>();

    }


    private void OnCollisionEnter(Collision collision)
    {
        //typeOfSound.GoliathSound();

        if (collision.gameObject.tag == "SoundTag")
        {
            AudioTom.PlayOneShot(tsound);
        }
           
    }
}
