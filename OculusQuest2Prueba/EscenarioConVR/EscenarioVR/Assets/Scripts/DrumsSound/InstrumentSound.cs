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
   // public Material materialPlano;

    public CheckStickHit hitCollision;

   // public CheckMIDIOptions midioptions;
    public int[] nota = {};

    string insTag;


    float TimeHit2, t, db, v, e;

    float volMIDI;

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
        channel = MIDIOptions.MIDIChannel;
        midiMode = MIDIOptions.MIDIMode;
        pedalMode = MIDIOptions.PedalsMode;

        if (midiMode)
        {
      
            nota = selectNote(insTag,channel);
            

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



                volMIDI = (db * 127.0f);
                //Debug.Log("VOLUMEN MIDI" + (int)volMIDI);
               
      
                AudioInstrument.volume = db;
                AudioInstrument.PlayOneShot(sound);

                if (midiMode)
                {
                    nota[1] = (int)volMIDI;
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
        int[] notaGOLIATH1 = {43,120,c};
        int[] notaGOLIATH2 = { 41, 120, c };
        int[] notaTOM1 = { 50, 120, c };
        int[] notaTOM2 = { 48, 120, c };
        int[] notaTOM3 = { 45, 120, c };
        int[] notaRIDE = { 63, 120, c};
        int[] notaCRASH1 = { 60, 120, c };
        int[] notaCRASH2 = { 57, 120, c };
        int[] notaCRASH3 = { 51, 120, c };


        switch (tag)
        {
            case "Goliath1":
                notaMIDI = notaGOLIATH1;
                break;
            case "Goliath2":
                notaMIDI = notaGOLIATH2;
                break;
            case "Tom1":
                notaMIDI = notaTOM1;
                break;
            case "Tom2":
                notaMIDI = notaTOM2;
                break;
            case "Tom3":
                notaMIDI = notaTOM3;
                break;
            case "Ride":
                notaMIDI = notaRIDE;
                break;
            case "Crash1":
                notaMIDI = notaCRASH1;
                break;
            case "Crash2":
                notaMIDI = notaCRASH2;
                break;
            case "Crash3":
                notaMIDI = notaCRASH3;
                break;
        }

        
        return notaMIDI;
    }
   
}
