using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObjectToCreate : MonoBehaviour

{

    
    public void AddObject(GameObject obj)
    {
        Quaternion rot = obj.transform.rotation;
        Instantiate(obj, Vector3.zero,rot);
    }
}
