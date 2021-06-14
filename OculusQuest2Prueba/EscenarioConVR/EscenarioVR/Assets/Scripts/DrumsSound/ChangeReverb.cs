using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeReverb : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject snare, tom1, tom2, tom3,
        crash1, crash2, crash3, ride, hihat, kick, goliath, goliath2;


    AudioReverbFilter reverb, r_snare, r_tom1, r_tom2, r_tom3,
        r_crash1, r_crash2, r_crash3, r_ride, r_hihat, r_kick, r_goliath, r_goliath2;

    void Start()
    {
        reverb =GetComponent<AudioReverbFilter>();
        GetReverbFilters();
        ChangeReverbFilters();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetReverbFilters()
    {
        r_snare = snare.GetComponent<AudioReverbFilter>();
        r_tom1 = tom1.GetComponent<AudioReverbFilter>();
        r_tom2 = tom2.GetComponent<AudioReverbFilter>();
        r_tom3 = tom3.GetComponent<AudioReverbFilter>();
        r_crash1 = crash1.GetComponent<AudioReverbFilter>();
        r_crash2 = crash2.GetComponent<AudioReverbFilter>();
        r_crash3 = crash3.GetComponent<AudioReverbFilter>();
        r_ride = ride.GetComponent<AudioReverbFilter>();
        r_hihat = hihat.GetComponent<AudioReverbFilter>();
        r_kick = kick.GetComponent<AudioReverbFilter>();
        r_goliath = goliath.GetComponent<AudioReverbFilter>();
        r_goliath2 = goliath.GetComponent<AudioReverbFilter>();
    }

    public void ChangeReverbFilters()
    {
        r_snare = reverb;
        r_tom1 = reverb;
        r_tom2 = reverb;
        r_tom2 = reverb;
        r_crash1 = reverb;
        r_crash2 = reverb;
        r_crash3 = reverb;
        r_ride = reverb;
        r_hihat = reverb;
        r_kick = reverb;
        r_goliath = reverb;
        r_goliath2 = reverb;
    }
}
