using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnareSound : MonoBehaviour
{


   public float TimeHitHoop;
    public float TimeHitSnare;

    public GameObject snare;
    AudioSource AudioSnare;
    public AudioClip stroke;
    public AudioClip hoop;
    public AudioClip rimshot;
    public PlaneOne plane1;


    void Start()
    {

        AudioSnare = snare.GetComponent<AudioSource>();

    }

    public void OnTriggerEnter(Collider other)
    {
        if (plane1.timeHit1 != 0)
        {
            if (TimeHitHoop > 0.0f && TimeHitSnare > 0.0f && (TimeHitSnare - TimeHitHoop <= Mathf.Abs(0.07f)))
            {
                AudioSnare.PlayOneShot(rimshot);
                TimeHitHoop = 0.0f;
                TimeHitSnare = 0.0f;
            }

            else if (TimeHitSnare > 0 && TimeHitHoop == 0)
            {
                AudioSnare.PlayOneShot(stroke);
                TimeHitHoop = 0.0f;
                TimeHitSnare = 0.0f;
            }

            else if (TimeHitSnare == 0 && TimeHitHoop > 0)
            {
                AudioSnare.PlayOneShot(hoop);
                TimeHitHoop = 0.0f;
                TimeHitSnare = 0.0f;
            }

            plane1.timeHit1 = 0;

        }


    }

    /*
    public void OnCollisionEnter(Collision collision)
    {
        if (plane1.timeHit1 != 0)
        {
            if (TimeHitHoop > 0.0f && TimeHitSnare > 0.0f && (TimeHitSnare - TimeHitHoop <= Mathf.Abs(0.07f)))
            {
                AudioSnare.PlayOneShot(rimshot);
                TimeHitHoop = 0.0f;
                TimeHitSnare = 0.0f;
            }

            else if (TimeHitSnare > 0 && TimeHitHoop == 0)
            {
                AudioSnare.PlayOneShot(stroke);
                TimeHitHoop = 0.0f;
                TimeHitSnare = 0.0f;
            }

            else if (TimeHitSnare == 0 && TimeHitHoop > 0)
            {
                AudioSnare.PlayOneShot(hoop);
                TimeHitHoop = 0.0f;
                TimeHitSnare = 0.0f;
            }

            plane1.timeHit1 = 0;

        }


        
        foreach (ContactPoint contact in collision.contacts)
        {

            Debug.Log(contact.point.x);
            if (contact.point.x < -2.9 || contact.point.x > -2.6)
            {
            
                TimeHitHoop = Time.deltaTime;
                

            }

            if (contact.point.x > -2.9 && contact.point.x < -2.6)
            {
               
                TimeHitSnare = Time.deltaTime;
                
            }

        }
        



    }
    

            
    
    }

    */
}

   
