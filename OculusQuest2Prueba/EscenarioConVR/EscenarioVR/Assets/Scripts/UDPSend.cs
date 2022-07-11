using UnityEngine;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class UDPSend: MonoBehaviour
{
    public string IP { get; private set; }
    public int sourcePort { get; private set; } 
    public int remotePort { get; private set; }

    IPEndPoint remoteEndPoint;

    public KickDrumSound kick;
    public HiHatSound hihat;


    public static string textReceived;


    Thread receiveThread;

    UdpClient client;

    bool pedalmode = MIDIOptions.PedalsMode;
    public int port = 25666; 

    

    public bool newdata = false;

    public void init(string IPAdress, int RemotePort, int SourcePort = -1) // If sourceport is not set, its being chosen randomly by the system
    {
        IP = IPAdress;
        sourcePort = SourcePort;
        remotePort = RemotePort;

        remoteEndPoint = new IPEndPoint(IPAddress.Parse(IP), remotePort);
        if (sourcePort <= -1)
        {
            client = new UdpClient();
            
        }
        else
        {
            client = new UdpClient(sourcePort);
       
        }

        receiveThread = new Thread(
            new ThreadStart(ReceiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();

    }

    private void ReceiveData()
    {

        if (pedalmode)
        {

            while (true)
            {
                try
                {
                    IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
                    byte[] data = client.Receive(ref anyIP);

                    string text = Encoding.UTF8.GetString(data);


                    if (text == "k")
                    {
                        kick.kickpedal();

                    }
                    if (text == "h")
                    {
                        hihat.hihatpedal();

                    }


                }
                catch (Exception err)
                {
                    Debug.Log(err.ToString());
                }
            }

        }
    }

    public void sendInt32Array(Int32[] myInts)
    {
        try
        {
            byte[] data = new byte[myInts.Length * sizeof(Int32)];
   
            Buffer.BlockCopy(myInts, 0, data, 0, 4);
            Buffer.BlockCopy(myInts, 4, data, 1, 4);
            Buffer.BlockCopy(myInts, 8, data, 2, 4);

            client.Send(data, data.Length, remoteEndPoint);

        }
        catch (Exception err)
        {
            Debug.Log(err.ToString());
        }
    }

    public void ClosePorts()
    {
        Debug.Log("closing receiving UDP on port: " + port);

        if (receiveThread != null)
            receiveThread.Abort();

        client.Close();
    }

 

}