using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomSound : MonoBehaviour
{
    
    public TypeOfSoundController typeOfSound;
    Collider body;

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
                typeOfSound.TomSound();
            }
            else
            {
                typeOfSound.TomSound();
            }


        }
    }
}
