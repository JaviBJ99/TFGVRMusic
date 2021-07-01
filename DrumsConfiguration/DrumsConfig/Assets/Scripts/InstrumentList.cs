using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentList : MonoBehaviour
{
    // Start is called before the first frame update
    public CreateJSON jsonclass;
    public List<GameObject> instrumentslist = new List<GameObject>();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallJson()
    {
        for (int i = 0; i < instrumentslist.Count; i++)
        {
            Debug.Log(instrumentslist[i].transform.position);
        }
        jsonclass.AddInstrument(instrumentslist);
    }
}
