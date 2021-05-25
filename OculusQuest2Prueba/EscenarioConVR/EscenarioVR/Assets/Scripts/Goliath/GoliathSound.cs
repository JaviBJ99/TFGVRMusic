using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class GoliathSound : MonoBehaviour
{

  
    public GameObject goliath;
    AudioSource AudioGoliath;
    public AudioClip  gsound;

    private Rigidbody rb;

    private Vector3 speed;

    void Start()
    {
        
        AudioGoliath = goliath.GetComponent<AudioSource>();

    }


    private void OnCollisionEnter(Collision collision)
    {
        
        
        if (collision.gameObject.tag == "SoundTag")
        {
            AudioGoliath.PlayOneShot(gsound);
        }
      
        
        
    }
    

   /* private void OnTriggerEnter(Collider other)
    {

        rb = other.GetComponent<Rigidbody>();

        if (rb.velocity.y > 0)
        {
            AudioGoliath.PlayOneShot(gsound);
        }
    }
    */
}
