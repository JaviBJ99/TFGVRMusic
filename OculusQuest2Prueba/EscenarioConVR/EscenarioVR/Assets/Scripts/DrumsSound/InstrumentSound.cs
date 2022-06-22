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
    public manager managerMIDI;
    public CheckMIDIOptions midioptions;

    public int[] nota = {};

    string insTag;


    float TimeHit2, t, db, v, e;

    public Text texto;

    public int bufferLength, numBuffers;

    int channel;
    bool midiMode, pedalMode;

    float totalHits = 0;
    float totalv = 0;
    float average = 0;

    Vector3 distance;

    void Start()
    {

        AudioInstrument = instrument.GetComponent<AudioSource>();
        insTag = instrument.gameObject.tag;
        channel = midioptions.channel;
        midiMode = midioptions.Mmode;
        pedalMode = midioptions.Pmode;
        if (midiMode)
        {
            nota = selectNote(insTag,channel);
        }
        
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

                if (midiMode)
                {
                    managerMIDI.sendMIDI(nota);
                }
               
                
            
            }


            TimeHit2 = 0;
            plane1.timeHit1 = 0;


        }

    }

    private int[] selectNote(string tag, int c)
    {
        int[] notaMIDI = {};
        int[] notaGOLIATH1 = {41,120,c};
        int[] notaTOM1 = { 42, 120, c }; 
        int[] notaRIDE = { 63, 120, c};




        switch (tag)
        {
            case "Goliath1":
                notaMIDI = notaGOLIATH1;
                break;

            case "Tom1":
                notaMIDI = notaTOM1;
                break;

            case "Ride":
                notaMIDI = notaRIDE;
                break;
        }

        
        return notaMIDI;
    }
   
}
