using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class GoliathSound : MonoBehaviour
{

  
    public GameObject goliath;
    AudioSource AudioGoliath;
    public AudioClip  gsound;

    public PlaneOne plane1;

    float TimeHit2;

    public int bufferLength, numBuffers;
    void Start()
    {
        
        AudioGoliath = goliath.GetComponent<AudioSource>();

    }


    private void OnCollisionEnter(Collision collision)
    {
        if (plane1.timeHit1 != 0 && collision.gameObject.tag == "SoundTag")
        {
            TimeHit2 = Time.time;
            
            AudioGoliath.PlayOneShot(gsound);
            AudioSettings.GetDSPBufferSize(out bufferLength, out numBuffers);

            Debug.Log(bufferLength);
            Debug.Log(numBuffers);

            TimeHit2 = 0;
            plane1.timeHit1 = 0;


        }
   
    }
    
}
