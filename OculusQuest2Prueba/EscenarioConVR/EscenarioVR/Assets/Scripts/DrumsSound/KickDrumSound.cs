using System.Collections;
using System.Collections;
using UnityEngine;

public class KickDrumSound : MonoBehaviour
{
    public PrimaryButtonWatcher watcher;
    public bool IsPressed = false; // used to display button state in the Unity Inspector window

    public GameObject kick, pedal, maza;
    AudioSource AudioKick;
    public AudioClip ksound;
    private Animation m, p;
    public manager managerMIDI;

    bool midimode;

    //public UDPSend sender = new UDPSend();

    string signal;

    public int[] kickmidisound = { 35, 120, 16 };



    void Start()
    {
        watcher.primaryButtonPress.AddListener(onPrimaryButtonEvent);
        AudioKick = kick.GetComponent<AudioSource>();
        m = maza.GetComponent<Animation>(); 
        p = pedal.GetComponent<Animation>();
        midimode = MIDIOptions.MIDIMode;
        
        if (midimode)
        {
            CheckMIDIChannel();
        }
      

    }




    public void onPrimaryButtonEvent(bool pressed)
    {
        if (pressed) {

            AudioKick.PlayOneShot(ksound);
            m.Play();
            p.Play();

            if (midimode)
            {
                managerMIDI.sendMIDI(kickmidisound);
            }

        }
           
    }

    public void kickpedal()
    {
        AudioKick.PlayOneShot(ksound);
        m.Play();
        p.Play();

        if (midimode)
        {
            managerMIDI.sendMIDI(kickmidisound);
        }


    }

    
    void CheckMIDIChannel()
    {
        kickmidisound[2] = MIDIOptions.MIDIChannel;
    }
   
}