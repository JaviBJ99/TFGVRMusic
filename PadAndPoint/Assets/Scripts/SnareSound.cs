using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnareSound : MonoBehaviour
{


    public AudioSource snare;
  
  
    /*
    private void OnTriggerEnter(Collider other)
    {
        volumen = plane2.timeHit - plane1.timeHit;
        volumen = volumen / 10;
        volumen = 1 - volumen;
        snare.volume = volumen;
        snare.Play();

        Debug.Log(volumen);
        Debug.Log("Plane 1" + plane1.timeHit);
        Debug.Log("Plane 2" + plane2.timeHit);

    }
    */


    public void PlaySnareSound(float vol)
    {
        snare.volume = vol;
        snare.Play();

    }

    

}
