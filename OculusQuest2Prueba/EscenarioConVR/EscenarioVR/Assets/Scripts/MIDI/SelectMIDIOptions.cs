using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMIDIOptions : MonoBehaviour
{
    void Start()
    {
        MIDIOptions.MIDIChannel = 16;
        MIDIOptions.MIDIMode = true;
        MIDIOptions.PedalsMode = true;

    }

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
                n = 16;
                break;
            case 1:
                n = 10;
                break;
           
        }

        MIDIOptions.MIDIChannel = n;
    }

    public void ActivatePedalsMode(bool p)
    {
        MIDIOptions.PedalsMode = p;
    }
}
