using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSoundBody : MonoBehaviour
{
    public Cymbal cymbalClass;
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
                cymbalClass.NormalRideSound();
            }
            else
            {
                cymbalClass.NormalRideSound();
            }

        }
    }
}
