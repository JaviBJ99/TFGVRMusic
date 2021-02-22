using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSound : MonoBehaviour
{
    public TypeOfSoundController typeOfSound;
    Collider body;

    void Start()
    {
        body = GetComponent<Collider>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        typeOfSound.CrashSound();
    }
}
