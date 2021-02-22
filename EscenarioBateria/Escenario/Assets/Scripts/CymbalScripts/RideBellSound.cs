using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RideBellSound : MonoBehaviour
{

    public TypeOfSoundController typeOfSound;
    Collider bell;
  
    void Start()
    {
        bell = GetComponent<Collider>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        typeOfSound.BellSound();
    }
}
