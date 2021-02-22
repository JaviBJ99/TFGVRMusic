using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHihatSound : MonoBehaviour
{
    public TypeOfSoundController typeOfSound;
    Collider body;

    public Boolean isOpen = true;
    void Start()
    {
        body = GetComponent<Collider>();

    }

   

    private void OnCollisionEnter(Collision collision)
    {
        typeOfSound.HiHatSound(isOpen);
    }
  
}
