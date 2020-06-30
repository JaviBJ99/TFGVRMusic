using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopSound : MonoBehaviour
{


    public AudioSource hoop;

    public SoundController soundcont;

    private void OnTriggerEnter(Collider other)
    {


        soundcont.HoopDetectSound();

    }



}