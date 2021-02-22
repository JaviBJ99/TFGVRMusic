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
        foreach (ContactPoint contact in collision.contacts)
        {
            if (body.bounds.Contains(contact.point))
            {
                typeOfSound.HiHatSound(isOpen);
            }
            else
            {
                typeOfSound.HiHatSound(isOpen);
            }


        }
    }
  
}
