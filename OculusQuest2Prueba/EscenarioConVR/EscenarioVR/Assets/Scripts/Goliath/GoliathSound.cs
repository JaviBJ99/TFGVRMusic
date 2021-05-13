using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoliathSound : MonoBehaviour
{

  
    public GameObject goliath;
    AudioSource AudioGoliath;
    public AudioClip  gsound;
    

    void Start()
    {
        
        AudioGoliath = goliath.GetComponent<AudioSource>();

    }


    private void OnCollisionEnter(Collision collision)
    {

       

        AudioGoliath.PlayOneShot(gsound);
        
    }
}
