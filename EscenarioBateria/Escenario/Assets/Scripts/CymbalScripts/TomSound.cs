using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomSound : MonoBehaviour
{
    
    public TypeOfSoundController typeOfSound;
    Collider body;

    void Start()
    {
        body = GetComponent<Collider>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        typeOfSound.TomSound();
    }
}
