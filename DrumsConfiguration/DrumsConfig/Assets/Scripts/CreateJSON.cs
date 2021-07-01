using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using Newtonsoft.Json;

public class CreateJSON : MonoBehaviour

{
    string saveString;
    public GameObject kick, snare, hihat;


    public void AddInstrument(List<GameObject> l)
    {

        MyInstrumentsList instList = new MyInstrumentsList();

        SaveObjects inst = new SaveObjects
        {

            objectPosition = kick.transform.position,
            tag = kick.tag,



        };


        instList.instruments.Add(inst);

        inst = new SaveObjects
        {

            objectPosition = snare.transform.position,
            tag = snare.tag,


        };

        instList.instruments.Add(inst);

        inst = new SaveObjects
        {

            objectPosition = hihat.transform.position,
            tag = hihat.tag,
            

        };

        instList.instruments.Add(inst);




        for (int i = 0; i < l.Count; i++)
        {

            inst = new SaveObjects
            {

                objectPosition = l[i].GetComponent<Transform>().position,
                tag = l[i].tag,
               

            };

            instList.instruments.Add(inst);

        }



       

        saveString = JsonConvert.SerializeObject(instList);
       
        File.WriteAllText(Application.dataPath + "/savedate.txt", saveString);
        LoadInstruments();

    }

    public void LoadInstruments()
    {
        string stringlist = File.ReadAllText(Application.dataPath + "/savedate.txt");
        MyInstrumentsList nuevo = new MyInstrumentsList();

        nuevo = JsonConvert.DeserializeObject<MyInstrumentsList>(saveString);
        Debug.Log(nuevo.instruments[0].tag);
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
