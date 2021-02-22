﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeOfSoundController : MonoBehaviour
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


    public void CrashSound()
    {
        soundcont.audioSource.PlayOneShot(soundcont.crash);
    }

    public void GoliathSound()
    {
        soundcont.audioSource.PlayOneShot(soundcont.goliath);
    }
    
    public void TomSound()
    {
        soundcont.audioSource.PlayOneShot(soundcont.tom);
    }

    public void HiHatSound(bool open)
    {
        if (open)
            soundcont.audioSource.PlayOneShot(soundcont.openHiHat);
        else
            soundcont.audioSource.PlayOneShot(soundcont.closeHiHat);

    }
    public void SnareSound()
    {
        soundcont.audioSource.PlayOneShot(soundcont.snare);
    }
    public void HoopSound()
    {
        soundcont.audioSource.PlayOneShot(soundcont.hoop);
    }
    public void RimShotSound()
    {
        soundcont.audioSource.PlayOneShot(soundcont.rimshot);
    }

}
