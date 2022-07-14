using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiHatSound : MonoBehaviour
{
    public SecondaryButtonWatcher watcher;

    public GameObject hihat, top;

    private Animation move;

    AudioSource AudioHihat;

    public AudioClip opensound, closesound;

    public CheckStickHit hitCollision;

    public manager managerMIDI;
    
    int[] closeHH = {57,120,16};
    int[] openHH = {46,120,16};
    int[] pedalHH = {44,120,16};
    
    /*
    int[] closeHH = { 57, 120, 16 };
    int[] openHH = { 59, 120, 16 };
    int[] pedalHH = { 57, 120, 16 };
    */

    public UDPSend sender = new UDPSend();

    bool open = false;

    float TimeHit2;

    public PlaneOne plane1;

    float t, db;


    float volMIDI;

    bool midimode;

    void Start()
    {
        watcher.secondaryButtonPress.AddListener(onSecondaryButtonEvent);
        AudioHihat = hihat.GetComponent<AudioSource>();
        move = top.GetComponent<Animation>();
        midimode = MIDIOptions.MIDIMode;

        if (midimode)
        {
            CheckMIDIChannel();
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (plane1.timeHit1 != 0 && other.gameObject.tag == "SoundTag" && hitCollision.isCollision == false)
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

                AudioHihat.volume = db;

                volMIDI = (db * 127.0f);



                if (open)
                {
                    
                    AudioHihat.PlayOneShot(opensound);

                    if (midimode)
                    {
                        openHH[1] = (int)volMIDI;
                        managerMIDI.sendMIDI(openHH);
                    }
                }
                else
                {
                    
                    AudioHihat.PlayOneShot(closesound);

                    if (midimode)
                    {
                        closeHH[1] = (int)volMIDI;
                        managerMIDI.sendMIDI(closeHH);
                    }
                }

            }

            TimeHit2 = 0;
            plane1.timeHit1 = 0;


        }

    }


    public void onSecondaryButtonEvent(bool pressed)
    {
        if (pressed)
        {
           
            if (open)
            {
                AudioHihat.Stop();
                move.Play("Close");
                AudioHihat.PlayOneShot(closesound);
            }
            else
            {
                move.Play("Open");
                AudioHihat.PlayOneShot(opensound);
            }
            open = !open;
            
        }

    }

    public void hihatpedal()
    {

        if (open)
        {
            AudioHihat.Stop();
            move.Play("Close");
            AudioHihat.PlayOneShot(closesound);

            if (midimode)
            {
                managerMIDI.sendMIDI(pedalHH);
            }
        }
        else
        {
            move.Play("Open");
            AudioHihat.PlayOneShot(opensound);

            if (midimode)
            {
                managerMIDI.sendMIDI(openHH);
            }

        }
        open = !open; 

    }


    void CheckMIDIChannel()
    {
        closeHH[2] = MIDIOptions.MIDIChannel;
        openHH[2] = MIDIOptions.MIDIChannel;
        pedalHH[2] = MIDIOptions.MIDIChannel;


    }




}

