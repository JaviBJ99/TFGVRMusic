using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnareSound : MonoBehaviour
{


    public float TimeHitHoop;
    public float TimeHitPad;
    float TimeHit2, vol, db;

    public GameObject snare;
    AudioSource AudioSnare;
    public AudioClip stroke;
    public AudioClip hoop;
    public AudioClip rimshot;
    public PlaneOne plane1;


    public manager managerMIDI;
    public int[] snareMIDI = { 38, 120,16};
    public int[] rimshotMIDI = { 62, 120, 16};
    public int[] hoopMIDI = { 40, 120, 16 };

    float volMIDI;

    bool midimode;

    public CheckStickHit hitCollision;



    void Start()
    {

        AudioSnare = snare.GetComponent<AudioSource>();
        midimode = MIDIOptions.MIDIMode;

        if (midimode)
        {
            CheckMIDIChannel();
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        TimeHit2 = Time.time;

        if (plane1.timeHit1 != 0)
        {
            if (TimeHitHoop > 0.0f && TimeHitPad > 0.0f && (TimeHitPad - TimeHitHoop <= Mathf.Abs(0.07f)))
            {
                vol = Mathf.Abs(TimeHit2 - plane1.timeHit1);

                if (vol <= 0.8f)
                {

                    if (vol < 0.1f)
                    {
                        vol = 0.1f;
                    }

                    db = -20.0f * Mathf.Log10(vol);
                    db = db / 20.0f;

                    volMIDI = (db * 127.0f);

               

                    AudioSnare.PlayOneShot(rimshot);



                    if (midimode)
                    {
                        rimshotMIDI[1] = (int)volMIDI;
                        managerMIDI.sendMIDI(rimshotMIDI);

                    }


                    TimeHitHoop = 0.0f;
                    TimeHitPad = 0.0f;
                }
            }
            else if (TimeHitPad > 0 && TimeHitHoop == 0 && hitCollision.isCollision == false)
            {

                vol = Mathf.Abs(TimeHit2 - plane1.timeHit1);

                if (vol <= 0.8f)
                {

                    if (vol < 0.1f)
                    {
                        vol = 0.1f;
                    }

                    db = -20.0f * Mathf.Log10(vol);
                    db = db / 20.0f;


                    volMIDI = (db * 127.0f);


                    AudioSnare.PlayOneShot(stroke);

                    if (midimode)
                    {
                        snareMIDI[1] = (int)volMIDI;
                        managerMIDI.sendMIDI(snareMIDI);
                    }

                    TimeHitHoop = 0.0f;
                    TimeHitPad = 0.0f;


                }
            }

            else if (TimeHitPad == 0 && TimeHitHoop > 0 && hitCollision.isCollision == false)
            {

                vol = Mathf.Abs(TimeHit2 - plane1.timeHit1);

                if (vol <= 0.8f)
                {

                    if (vol < 0.1f)
                    {
                        vol = 0.1f;
                    }

                    db = -20.0f * Mathf.Log10(vol);
                    db = db / 20.0f;


                    volMIDI = (db * 127.0f);

                    AudioSnare.PlayOneShot(hoop);

                    if (midimode)
                    {
                        hoopMIDI[1] = (int)volMIDI;
                        managerMIDI.sendMIDI(hoopMIDI);
                    }

                    TimeHitHoop = 0.0f;
                    TimeHitPad = 0.0f;
                }

                plane1.timeHit1 = 0;

            }



        }

    }


    void CheckMIDIChannel()
    {
        snareMIDI[2] = MIDIOptions.MIDIChannel;
        hoopMIDI[2] = MIDIOptions.MIDIChannel;
        rimshotMIDI[2] = MIDIOptions.MIDIChannel;


    }

}

/*
public void OnCollisionEnter(Collision collision)
{
    if (plane1.timeHit1 != 0)
    {
        if (TimeHitHoop > 0.0f && TimeHitPad > 0.0f && (TimeHitPad - TimeHitHoop <= Mathf.Abs(0.07f)))
        {
            AudioSnare.PlayOneShot(rimshot);
            TimeHitHoop = 0.0f;
            TimeHitPad = 0.0f;
        }

        else if (TimeHitPad > 0 && TimeHitHoop == 0)
        {
            AudioSnare.PlayOneShot(stroke);
            TimeHitHoop = 0.0f;
            TimeHitPad = 0.0f;
        }

        else if (TimeHitPad == 0 && TimeHitHoop > 0)
        {
            AudioSnare.PlayOneShot(hoop);
            TimeHitHoop = 0.0f;
            TimeHitPad = 0.0f;
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

            TimeHitPad = Time.deltaTime;

        }

    }




}




}

*/




