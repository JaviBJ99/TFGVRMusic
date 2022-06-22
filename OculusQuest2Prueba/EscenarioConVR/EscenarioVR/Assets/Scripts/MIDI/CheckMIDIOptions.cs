using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMIDIOptions : MonoBehaviour
{
    // Start is called before the first frame update

    public int channel;

    public bool Mmode, Pmode;
    void Start()
    {
        channel = MIDIOptions.MIDIChannel;
        Mmode = MIDIOptions.MIDIMode;
        Pmode = MIDIOptions.MIDIMode;



        //SelectChannel(MIDIOptions.MIDIChannel);
        //SelectMMode(MIDIOptions.MIDIMode);
        //SelectMMode(MIDIOptions.PedalsMode);



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelectChannel(int c)
    {
        channel = c;
    }

    void SelectMMode(bool m)
    {
        Mmode = m;
    }

    void SelectPMode(bool p)
    {
        Pmode = p;
    }


}
