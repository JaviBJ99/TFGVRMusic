using System.Collections;
using System.Collections;
using UnityEngine;

public class KickDrumSound : MonoBehaviour
{
    public PrimaryButtonWatcher watcher;
    public bool IsPressed = false; // used to display button state in the Unity Inspector window

    public GameObject kick;
    AudioSource AudioKick;
    public AudioClip ksound;


    void Start()
    {
        watcher.primaryButtonPress.AddListener(onPrimaryButtonEvent);
        AudioKick = kick.GetComponent<AudioSource>();
    }

    public void onPrimaryButtonEvent(bool pressed)
    {
        if (pressed) {

            AudioKick.PlayOneShot(ksound);
        }
           
    }

    

   
}