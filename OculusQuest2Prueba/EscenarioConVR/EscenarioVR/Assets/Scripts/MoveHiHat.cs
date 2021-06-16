using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoveHiHat : MonoBehaviour
{
    // Start is called before the first frame update
    public SecondaryButtonWatcher watcher;
    Vector3 closepos, openpos;
    bool open = false;
    private Animation h;
    void Start()
    {
        watcher.secondaryButtonPress.AddListener(onSecondaryButtonEvent);
        closepos = transform.position;
        openpos = closepos + new Vector3(0, 0.08f, 0);
        h = GetComponent<Animation>();
        Debug.Log(closepos);
        Debug.Log(openpos);
        
    }

    // Update is called once per frame
 
    public void onSecondaryButtonEvent(bool pressed)
    {
        Debug.Log("funciona");
        if (pressed)
        {
            
            if (open)
            {

                h.Play("Close");
            }
            else
            {
                h.Play("Open");

            }
            open = !open;

        }

    }




   
    public void HiHatMove(bool open)
    {
        if (open)
        {

            //transform.position =  Vector3.MoveTowards(openpos, closepos, 0.2f * Time.deltaTime);
            transform.position = closepos;
        }
        else
        {
            transform.position = openpos;
            //transform.position = Vector3.MoveTowards(closepos, openpos, 0.2f * Time.deltaTime);
        }

    }
}
