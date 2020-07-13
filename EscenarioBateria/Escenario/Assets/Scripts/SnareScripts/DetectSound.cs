using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectSound : MonoBehaviour
{

    public SoundController soundcont;

    float TimeHitHoop;
    float TimeHitSnare;


    public void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {

            Debug.Log(contact.point.x);
            if (contact.point.x < -2.9 || contact.point.x > -2.6)
            {
                //soundcont.HoopDetectSound();
                TimeHitHoop = Time.deltaTime;
                Debug.Log(TimeHitHoop);

            }

            if (contact.point.x > -2.9 && contact.point.x < -2.6)
            {
                //soundcont.SnareDetectSound();
                TimeHitSnare = Time.deltaTime;
                Debug.Log(TimeHitSnare);
            }

        }

        if (TimeHitHoop > 0.0f && TimeHitSnare > 0.0f && (TimeHitSnare - TimeHitHoop <= Mathf.Abs(0.07f)))
        {
            Debug.Log("EHHHHH");
            soundcont.audioSource.PlayOneShot(soundcont.rimshot);
            TimeHitHoop = 0.0f;
            TimeHitSnare = 0.0f;
        }

        else if (TimeHitSnare > 0 && TimeHitHoop == 0)
        {
            Debug.Log("ARO");
            soundcont.audioSource.PlayOneShot(soundcont.snare);
            TimeHitHoop = 0.0f;
            TimeHitSnare = 0.0f;
        }

        else if (TimeHitSnare == 0 && TimeHitHoop > 0)
        {
            Debug.Log("CAJA");
            soundcont.audioSource.PlayOneShot(soundcont.hoop);
            TimeHitHoop = 0.0f;
            TimeHitSnare = 0.0f;
        }


    }
}
