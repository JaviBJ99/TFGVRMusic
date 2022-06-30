using UnityEngine;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class UDPSend: MonoBehaviour
{
    public string IP { get; private set; }
    public int sourcePort { get; private set; } // Sometimes we need to define the source port, since some devices only accept messages coming from a predefined sourceport.
    public int remotePort { get; private set; }

    IPEndPoint remoteEndPoint;

    public KickDrumSound kick;
    public HiHatSound hihat;


    public static string textReceived;


    Thread receiveThread;

    // udpclient object
    UdpClient client;

    // public
    // public string IP = "127.0.0.1"; default local
    public int port = 25666; // define > init

    // Information
    public string lastReceivedUDPPacket = "";
    public string allReceivedUDPPackets = ""; // Clean up this from time to time!

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
            //Debug.Log("Sending to " + IP + ": " + remotePort);
        }
        else
        {
            client = new UdpClient(sourcePort);
            //Debug.Log("Sending to " + IP + ": " + remotePort + " from Source Port: " + sourcePort);
        }

        receiveThread = new Thread(
            new ThreadStart(ReceiveData));
        receiveThread.IsBackground = true;
        receiveThread.Start();

    }

    private void ReceiveData()
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
                
                newdata = true;

                lastReceivedUDPPacket = text;

               
               // allReceivedUDPPackets = allReceivedUDPPackets + text;
            }
            catch (Exception err)
            {
                Debug.Log(err.ToString());
            }
        }
    }

    // sendData in different ways. Can be extended accordingly
    public void sendString(string message)
    {
        try
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            client.Send(data, data.Length, remoteEndPoint);

        }
        catch (Exception err)
        {
            Debug.Log(err.ToString());
        }
    }

    public void sendInt32(Int32 myInt)
    {
        try
        {
            byte[] data = BitConverter.GetBytes(myInt);
            //Debug.Log("se van a copiar " + data.Length + " bytes");
            client.Send(data, data.Length, remoteEndPoint);
        }
        catch (Exception err)
        {
            Debug.Log(err.ToString());
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

    public void sendInt16Array(Int16[] myInts)
    {
        try
        {
            byte[] data = new byte[myInts.Length * sizeof(Int16)];
            Buffer.BlockCopy(myInts, 0, data, 0, data.Length);
            client.Send(data, data.Length, remoteEndPoint);
        }
        catch (Exception err)
        {
            Debug.Log(err.ToString());
        }
    }

    public string getLatestUDPPacket()
    {
        allReceivedUDPPackets = "";
        return lastReceivedUDPPacket;
    }

    public void ClosePorts()
    {
        Debug.Log("closing receiving UDP on port: " + port);

        if (receiveThread != null)
            receiveThread.Abort();

        client.Close();
    }

 

}