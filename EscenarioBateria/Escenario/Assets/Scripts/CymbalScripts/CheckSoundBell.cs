﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSoundBell : MonoBehaviour
{

    public Cymbal cymbalClass;
    Collider bell;
  
    void Start()
    {
        bell = GetComponent<Collider>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            if (bell.bounds.Contains(contact.point))
            {
                cymbalClass.BellSound();
            } else
            {
                cymbalClass.NormalRideSound();
            }

        }
    }
}
