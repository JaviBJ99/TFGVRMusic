using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMIDIOptions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MIDIOptions.MIDIChannel = 10;
        MIDIOptions.MIDIMode = true;
        MIDIOptions.PedalsMode = true;

    }


    // Update is called once per frame

    public void ActivateMIDIMode(bool m)
    {
        MIDIOptions.MIDIMode = m;
    }

    public void SelectMIDIChannel(int c)
    {
        int n = 0;
        switch (c)
        {
            case 0:
                n = 10;
                break;
            case 1:
                n = 16;
                break;
            case 2:
                n = 20;
                break;

        }

        Debug.Log(n);
        MIDIOptions.MIDIChannel = n;
    }

    public void ActivatePedalsMode(bool p)
    {
        MIDIOptions.PedalsMode = p;
    }
}
