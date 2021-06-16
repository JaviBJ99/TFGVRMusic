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
        distance = transform.position - instrument.transform.position;
        e = Mathf.Abs(distance.y);
    }




    private void OnTriggerEnter(Collider other)
    {
        if (plane1.timeHit1 != 0 && other.gameObject.tag == "SoundTag")
        {
            totalHits += 1;
            TimeHit2 = Time.time;

            t = Mathf.Abs(TimeHit2 - plane1.timeHit1);

            

            if (t <= 1.1f)
            {

                if (t < 0.1f)
                {
                    t = 0.1f;
                }

               
                v = e / t;
                totalv += v;
                average = totalv / totalHits;


                db = -20.0f * Mathf.Log10(t);
                db = db / 20.0f;

                AudioInstrument.volume = db;
                AudioInstrument.PlayOneShot(sound);



                AudioSettings.GetDSPBufferSize(out bufferLength, out numBuffers);


                //texto.text = "bufferLength " + bufferLength + " numBuffers " + numBuffers + " sample rate " + AudioSettings.outputSampleRate;
                //texto.text = "velocidad " + v + " decibelios" + db;
                //texto.text = "golpes " + totalHits + " velocidad total " + totalv + " velocidad media " + average;
                texto.text = "espacio " + e + " tiempo " + t; 
            }



            /*
            AudioSettings.GetDSPBufferSize(out bufferLength, out numBuffers);

            sampleRate = AudioSettings.outputSampleRate;
            

            console.showText(bufferLength, sampleRate);
            */

            TimeHit2 = 0;
            plane1.timeHit1 = 0;


        }

    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (plane1.timeHit1 != 0 && collision.gameObject.tag == "SoundTag")
        {
            TimeHit2 = Time.time;

            AudioInstrument.PlayOneShot(sound);

            
            AudioSettings.GetDSPBufferSize(out bufferLength, out numBuffers);

            sampleRate = AudioSettings.outputSampleRate;
            

            console.showText(bufferLength, sampleRate);
            

            TimeHit2 = 0;
            plane1.timeHit1 = 0;


        }
    
    }
    */
}
