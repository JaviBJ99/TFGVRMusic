using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrokeCollider : MonoBehaviour
{
    public SnareSound snare;
    


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SoundTag")
        {
            snare.TimeHitSnare = Time.deltaTime;
          
        }


    }

}
