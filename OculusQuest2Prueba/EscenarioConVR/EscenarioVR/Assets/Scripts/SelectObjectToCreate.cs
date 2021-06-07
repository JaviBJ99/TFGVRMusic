using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObjectToCreate : MonoBehaviour

{
    public void AddObject(GameObject obj)
    {

        Quaternion rot = obj.transform.rotation;
        Vector3 pos;
        pos = new Vector3(-2.11f, 0.0f, 0.0f);
        Instantiate(obj, pos, rot);
        
    }
}
