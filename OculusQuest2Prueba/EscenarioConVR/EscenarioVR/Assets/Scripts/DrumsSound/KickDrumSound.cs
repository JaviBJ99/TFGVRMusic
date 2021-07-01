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



    void Start()
    {
        watcher.primaryButtonPress.AddListener(onPrimaryButtonEvent);
        AudioKick = kick.GetComponent<AudioSource>();
        m = maza.GetComponent<Animation>();
        p = pedal.GetComponent<Animation>();

      

    }

    public void onPrimaryButtonEvent(bool pressed)
    {
        if (pressed) {

            AudioKick.PlayOneShot(ksound);
            m.Play();
            p.Play();
        }
           
    }

    

   
}