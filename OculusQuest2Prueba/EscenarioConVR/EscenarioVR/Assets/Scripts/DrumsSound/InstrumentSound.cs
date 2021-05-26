using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstrumentSound : MonoBehaviour
{
    public GameObject instrument;
    AudioSource AudioInstrument;
    public AudioClip sound;

    public PlaneOne plane1;

    float TimeHit2;

    void Start()
    {

        AudioInstrument = instrument.GetComponent<AudioSource>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (plane1.timeHit1 != 0 && collision.gameObject.tag == "SoundTag")
        {
            TimeHit2 = Time.time;

            AudioInstrument.PlayOneShot(sound);

            TimeHit2 = 0;
            plane1.timeHit1 = 0;


        }

    }
}
