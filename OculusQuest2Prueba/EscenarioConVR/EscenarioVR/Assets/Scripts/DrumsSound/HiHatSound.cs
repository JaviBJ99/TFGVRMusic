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

    bool open = false;

    float TimeHit2;

    public PlaneOne plane1;

    float t, db;


    void Start()
    {
        watcher.secondaryButtonPress.AddListener(onSecondaryButtonEvent);
        AudioHihat = hihat.GetComponent<AudioSource>();
        move = top.GetComponent<Animation>();

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

                AudioHihat.volume = db;


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



    
}

