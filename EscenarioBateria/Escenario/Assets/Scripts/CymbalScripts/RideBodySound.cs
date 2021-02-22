using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideBodySound : MonoBehaviour
{
    public TypeOfSoundController typeOfSound;
    Collider body;
    
    void Start()
    {
        body = GetComponent<Collider>();
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        typeOfSound.NormalRideSound();
    }


}
