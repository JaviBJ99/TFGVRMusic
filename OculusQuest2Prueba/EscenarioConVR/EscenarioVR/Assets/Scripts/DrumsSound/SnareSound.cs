using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnareSound : MonoBehaviour
{


    float TimeHitHoop;
    float TimeHitSnare;

    public GameObject crash;
    AudioSource AudioSnare;
    public AudioClip stroke;
    public AudioClip hoop;
    public AudioClip rimshot;


    void Start()
    {

        AudioSnare = crash.GetComponent<AudioSource>();

    }




    public void OnCollisionEnter(Collision collision)
    {
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


    }
}
