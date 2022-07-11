using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class manager : MonoBehaviour
{

    public int Remoteport = 25666;

    public UDPSend sender = new UDPSend();

    public string datafromnode;

    public int[] midiOn = { 52, 120, 10 };

    bool midimode, pedalmode;

    void Start()
    {

        midimode = MIDIOptions.MIDIMode;
        pedalmode = MIDIOptions.PedalsMode;
       
        if (midimode || pedalmode)
        {
            sender.init("192.168.4.1", Remoteport, 25666);
        }
        

    }

    public void OnDisable()
    {
        sender.ClosePorts();
    }

    public void OnApplicationQuit()
    {
        sender.ClosePorts();
    }

    public void sendMIDI(int[] notamidi)
    {

        sender.sendInt32Array(notamidi);

    }

}