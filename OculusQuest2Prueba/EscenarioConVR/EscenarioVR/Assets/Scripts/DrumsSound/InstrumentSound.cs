using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstrumentSound : MonoBehaviour
{
    public GameObject instrument;
    AudioSource AudioInstrument;
    public AudioClip sound;

    public PlaneOne plane1;

    
    public int bufferLength, numBuffers, sampleRate;

    float TimeHit2;

    public Console console;

    void Start()
    {

        AudioInstrument = instrument.GetComponent<AudioSource>();

    }




    private void OnTriggerEnter(Collider other)
    {
        if (plane1.timeHit1 != 0 && other.gameObject.tag == "SoundTag")
        {
            TimeHit2 = Time.time;

            if (TimeHit2 - plane1.timeHit1 <= Mathf.Abs(0.7f))
            {
                AudioInstrument.PlayOneShot(sound);
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
