using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cymbal : MonoBehaviour
{
    public AudioController soundcont;

  
   public void BellSound()
    {
        soundcont.audioSource.PlayOneShot(soundcont.bell);
    }

   public void NormalRideSound()
    {
        soundcont.audioSource.PlayOneShot(soundcont.ride);
    }

}
