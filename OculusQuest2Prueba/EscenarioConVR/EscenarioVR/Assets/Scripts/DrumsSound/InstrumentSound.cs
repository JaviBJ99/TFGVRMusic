using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstrumentSound : MonoBehaviour
{
    public GameObject instrument;
    AudioSource AudioInstrument;
    public AudioClip sound;
    public PlaneOne plane1;


    float TimeHit2, vol, db;

    public Text texto;

    void Start()
    {

        AudioInstrument = instrument.GetComponent<AudioSource>();
    
    }




    private void OnTriggerEnter(Collider other)
    {
        if (plane1.timeHit1 != 0 && other.gameObject.tag == "SoundTag")
        {

            TimeHit2 = Time.time;

            vol = Mathf.Abs(TimeHit2 - plane1.timeHit1);

            if (vol <= 0.8f)
            {
                
                if (vol < 0.1f)
                {
                    vol = 0.1f;
                }
           
                db = -20.0f * Mathf.Log10(vol);
                db = db / 20.0f;
            
                AudioInstrument.volume = db;
                AudioInstrument.PlayOneShot(sound);
                //texto.text = "volumen " + vol + " decibelios" + db;
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
