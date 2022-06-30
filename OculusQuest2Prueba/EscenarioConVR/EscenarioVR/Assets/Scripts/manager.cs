using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class manager : MonoBehaviour
{

    public int Remoteport = 25666;

    public UDPSend sender = new UDPSend();

    public string datafromnode;

    public int[] midiOn = { 52, 120, 10 };

    public int[] midiOff = { 52, 0, 1 };

    public byte[] midibyte = { 52, 120, 1 };

    void Start()
    {

        //sender.init("192.168.1.67", Remoteport, 25666);
        sender.init("172.20.10.5", Remoteport, 25666);



        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
            sender.sendString("This should be delivered");

        if (sender.newdata)
        {
            datafromnode = sender.getLatestUDPPacket();
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