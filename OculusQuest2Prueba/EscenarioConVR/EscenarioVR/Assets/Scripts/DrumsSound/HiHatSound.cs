﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiHatSound : MonoBehaviour
{
    public SecondaryButtonWatcher watcher;
    public bool IsPressed = false; // used to display button state in the Unity Inspector window
    public MoveHiHat move;
    public GameObject hihat;
    AudioSource AudioHihat;
    public AudioClip opensound, closesound;
    bool open = false;

    float TimeHit2;

    Vector3 closepos, openpos;

    public PlaneOne plane1;


    void Start()
    {
        watcher.secondaryButtonPress.AddListener(onSecondaryButtonEvent);
        AudioHihat = hihat.GetComponent<AudioSource>();
   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (plane1.timeHit1 != 0 && other.gameObject.tag == "SoundTag")
        {
            TimeHit2 = Time.time;

            if (TimeHit2 - plane1.timeHit1 <= Mathf.Abs(0.7f))
            {
                if (open)
                {
                    AudioHihat.PlayOneShot(opensound);
                }
                else
                {
                    AudioHihat.PlayOneShot(closesound);
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
                Debug.Log(closepos);
                AudioHihat.Stop();
                //hihat.SetActive(true);
                //move.HiHatMove(!open);
                AudioHihat.PlayOneShot(closesound);

            }
            else
            {
                Debug.Log(openpos);
                //hihat.SetActive(false);
                //move.HiHatMove(open);
                AudioHihat.PlayOneShot(opensound);

            }
            open = !open;
            
        }

    }



    
}

