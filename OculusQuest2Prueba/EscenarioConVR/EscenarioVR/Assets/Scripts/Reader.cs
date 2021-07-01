using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using Newtonsoft.Json;
public class Reader : MonoBehaviour
{
    // Start is called before the first frame update
    public MyInstrumentsList nuevo = new MyInstrumentsList();
  
    Dictionary<string, GameObject> instruments = new Dictionary<string, GameObject>();

    public GameObject tom1, tom2, tom3, ride, goliath1, goliath2, crash1, crash2, crash3, kick, snare, hihat;

    
    void Start()
    {
        BetterStreamingAssets.Initialize();
        AddToDictionary();
        LoadInstruments();
        
    }


    public void LoadInstruments()
    {
        Debug.Log(System.IO.Directory.GetCurrentDirectory());
        string stringlist = BetterStreamingAssets.ReadAllText("savedata.txt") ;
        
       

        nuevo = JsonConvert.DeserializeObject<MyInstrumentsList>(stringlist);

        for (int i = 0; i <nuevo.instruments.Count; i++)
        {
            CreateObject(nuevo.instruments[i].tag, nuevo.instruments[i].objectPosition);
        }
    }
    public void AddToDictionary()
    {
        instruments.Add("Tom1", tom1);
        instruments.Add("Tom2", tom2);
        instruments.Add("Tom3", tom3);
        instruments.Add("Crash1", crash1);
        instruments.Add("Crash2", crash2);
        instruments.Add("Crash3", crash3);
        instruments.Add("Goliath1", goliath1);
        instruments.Add("Goliath2", goliath2);
        instruments.Add("Ride", ride);
        instruments.Add("Snare", snare);
        instruments.Add("Kick", kick);
        instruments.Add("Hihat", hihat);


    }

    public void CreateObject(string tag, Vector3 pos)
    {
        GameObject newInstrument = instruments[tag];
        Quaternion rot = newInstrument.transform.rotation;
        Instantiate(newInstrument, pos, rot);

    }

    [Serializable]
    public class SaveObjects
    {

        public string tag;
        public Vector3 objectPosition;
       
    }

    [Serializable]
    public class MyInstrumentsList
    {
        public List<SaveObjects> instruments = new List<SaveObjects>();

    }
}
