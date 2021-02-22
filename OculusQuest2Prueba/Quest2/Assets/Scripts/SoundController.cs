using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour

{

    public AudioSource audioSource;

    public AudioClip snare;
    public AudioClip hoop;
    public AudioClip rimshot;

    public bool soundDetected;
    public bool secondSound;

    float timeFirstHit;
    float timeSecondHit;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SnareDetectSound()
    {
        if(!soundDetected)
        {
            //StartCoroutine(WaitForInput(snare));
            soundDetected = true;
            timeFirstHit = Time.deltaTime;
        } else
        {
            secondSound = true;
            timeSecondHit = Time.deltaTime;
            selectSound(hoop);

        }
        

    }

    public void HoopDetectSound()
    {
        if (!soundDetected)
        {
            //StartCoroutine(WaitForInput(hoop));
            soundDetected = true;
            timeFirstHit = Time.deltaTime;
        }
        else
        {
            secondSound = true;
            timeSecondHit = Time.deltaTime;
            selectSound(snare);
        }
    }


    public void selectSound(AudioClip sound)
    {
        float totalTime = timeSecondHit - timeFirstHit;
        if (totalTime < 0.07f)
        {
            audioSource.PlayOneShot(rimshot);
        }
        else
        {
            audioSource.PlayOneShot(sound);
        }
        soundDetected = false;
        secondSound = false;

    }


    public IEnumerator WaitForInput(AudioClip sound)
    {
        bool soundon = true;
        float counter = 0f;

        while (soundon)
        {
            if (secondSound)
            {
                sound = rimshot;
            }
            counter += Time.deltaTime;
            if (counter >= 0.07f)
            {
                soundon = false;
            }

            yield return new WaitForEndOfFrame();
        }
        
        audioSource.PlayOneShot(sound);
        soundDetected = false;
        secondSound = false;
    }
}
