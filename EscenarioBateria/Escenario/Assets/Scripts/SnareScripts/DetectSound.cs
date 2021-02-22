using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectSound : MonoBehaviour
{

    //public SoundController soundcont;
    public TypeOfSoundController typeOfSound;

    float TimeHitHoop;
    float TimeHitSnare;


    public void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {

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

            typeOfSound.RimShotSound();
            TimeHitHoop = 0.0f;
            TimeHitSnare = 0.0f;
        }

        else if (TimeHitSnare > 0 && TimeHitHoop == 0)
        {

            typeOfSound.SnareSound();
            TimeHitHoop = 0.0f;
            TimeHitSnare = 0.0f;
        }

        else if (TimeHitSnare == 0 && TimeHitHoop > 0)
        {

            typeOfSound.HoopSound();
            TimeHitHoop = 0.0f;
            TimeHitSnare = 0.0f;
        }


    }
}
