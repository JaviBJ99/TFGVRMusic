using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class InstrumentSound : MonoBehaviour
{
    public GameObject instrument;
    AudioSource AudioInstrument;
    public AudioClip sound;
    public PlaneOne plane1;
 

    float TimeHit2, t, db, v, e;

    public Text texto;

    public int bufferLength, numBuffers;

    float totalHits = 0;
    float totalv = 0;
    float average = 0;

    Vector3 distance;

    void Start()
    {

        AudioInstrument = instrument.GetComponent<AudioSource>();

     
    }




    private void OnTriggerEnter(Collider other)
    {
        if (plane1.timeHit1 != 0 && other.gameObject.tag == "SoundTag")
        {
            TimeHit2 = Time.time;

            t = Mathf.Abs(TimeHit2 - plane1.timeHit1);

            if (t <= 1.1f)
            {

                if (t < 0.1f)
                {
                    t = 0.1f;
                }

                db = -20.0f * Mathf.Log10(t);
                db = db / 20.0f;

                AudioInstrument.volume = db;
                AudioInstrument.PlayOneShot(sound);
                
            
            }


            TimeHit2 = 0;
            plane1.timeHit1 = 0;


        }

    }
   
}
