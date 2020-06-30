using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cymbal : MonoBehaviour
{
    public AudioController soundcont;

    
    public void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {

            Debug.Log(contact.point.x);
            if (contact.point.x < 6.3 || contact.point.x > 7.3)
            {
                //soundcont.HoopDetectSound();
                //TimeHitHoop = Time.deltaTime;
                //Debug.Log(TimeHitHoop);

                soundcont.audioSource.PlayOneShot(soundcont.ride);

            }

            if (contact.point.x > 6.3 && contact.point.x < 7.3)
            {
                //soundcont.SnareDetectSound();
                //TimeHitSnare = Time.deltaTime;
                //Debug.Log(TimeHitSnare);
                soundcont.audioSource.PlayOneShot(soundcont.bell);

            }

        }
    }
}
