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


        //0.0.0.0
        //192.168.43.20


        sender.init("192.168.1.67", Remoteport, 25666);
        //sender.init("172.20.10.5", Remoteport, 25666);


        //sender.sendString("Hello from Start. " + Time.realtimeSinceStartup);
        //sender.sendString("52");

        sender.sendInt32Array(midiOn);
        //sender.sendInt32(52);
        //sender.sendInt32Array(midiOff);

        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
            sender.sendString("This should be delivered");

        if (sender.newdatahereboys)
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

        //sender.init("192.168.1.67", Remoteport, 25666);

        sender.sendInt32Array(notamidi);
        Debug.Log("se va a enviar un midi");

        Application.targetFrameRate = 60;


    }

}