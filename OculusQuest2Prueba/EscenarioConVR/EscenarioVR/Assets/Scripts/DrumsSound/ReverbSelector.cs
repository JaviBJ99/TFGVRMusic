using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverbSelector : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject audioChanger;
    AudioReverbFilter reverb, reverb2;
    void Start()
    {
        reverb = GetComponent<AudioReverbFilter>();
        reverb2 = audioChanger.GetComponent<AudioReverbFilter>();
        reverb.reverbPreset = reverb2.reverbPreset;
    }

 
    
}
