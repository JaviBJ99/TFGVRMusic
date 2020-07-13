using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideBellSound : MonoBehaviour
{

    public TypeOfSoundController typeOfSound;
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
                typeOfSound.BellSound();
            } else
            {
                typeOfSound.NormalRideSound();
            }

        }
    }
}
