using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideBellSound : MonoBehaviour
{

    
  
    public GameObject ride;
    AudioSource AudioBell;
    public AudioClip bsound;
    public manager managerMIDI;
    int[] nota = {53,120,16};
   // int[] nota = {62,120,16};


    bool midimode;

    void Start()
    {
        midimode = MIDIOptions.MIDIMode;
        AudioBell = ride.GetComponent<AudioSource>();

        if (midimode)
        {
            CheckMIDIChannel();
        }
    }



    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SoundTag")
        {
            AudioBell.PlayOneShot(bsound);
            
            if (midimode)
            {
                managerMIDI.sendMIDI(nota);
            }
            


        }

    }

    void CheckMIDIChannel()
    {
        nota[2] = MIDIOptions.MIDIChannel;
    }


}
