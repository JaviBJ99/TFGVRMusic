using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObjectToCreate : MonoBehaviour
{
    
    public InstrumentList lista;
    List<GameObject> instrumentslist = new List<GameObject>();
    public void AddObject(GameObject obj)
    {

        Quaternion rot = obj.transform.rotation;
        Vector3 pos;
        pos = new Vector3(-2.0f, 0.0f, 0.0f);
        GameObject clone =  Instantiate(obj, pos, rot);
        Debug.Log(pos);
        lista.instrumentslist.Add(clone);
       
        
    }
}
