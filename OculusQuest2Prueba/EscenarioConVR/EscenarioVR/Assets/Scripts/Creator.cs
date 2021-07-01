using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using Newtonsoft.Json;

public class Creator : MonoBehaviour
{
    // Start is called before the first frame update
    Dictionary<string, GameObject> instruments = new Dictionary<string, GameObject>();

    public GameObject tom1, tom2, tom3, ride, goliath1, goliath2, crash1, crash2, crash3;

    public Reader readerInstruments;

    public MyInstrumentsList instrumentsList = new MyInstrumentsList();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToDictionary()
    {
        instruments.Add("tom1", tom1);
        instruments.Add("tom2", tom2);
        instruments.Add("tom3", tom3);
        instruments.Add("crash1", crash1);
        instruments.Add("crash2", crash2);
        instruments.Add("crash3", crash3);
        instruments.Add("goliath1", goliath1);
        instruments.Add("goliath2", goliath2);
        instruments.Add("ride", ride);

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
        //public Quaternion rot;  
    }

    [Serializable]
    public class MyInstrumentsList
    {
        public List<SaveObjects> instruments = new List<SaveObjects>();

        //public SaveObjects[] instrumentos = new SaveObjects[50];
    }


}
